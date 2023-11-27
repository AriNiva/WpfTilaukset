using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTilaukset
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime tänään = DateTime.Today;
        Decimal RivienSummaYht = 0;
        public MainWindow()
        {
            InitializeComponent();
            HaeAsiakkaat(); //Täytetään Asiakas - comboboxin sisältö
            HaeTuotteet();

            dpTilausPvm.SelectedDate = tänään; //Datepickerin oletuspvm
            dpToimitusPvm.SelectedDate = tänään.AddDays(14); //Datepickerin oletuspvm
            //Luodaan ikäänkuin ilmaan DataGridTextColumn - tyyppisiä oliota. Nämä ovat sarakkeita joita gridiin laitetaan
            DataGridTextColumn colTilausRiviNumero = new DataGridTextColumn();
            DataGridTextColumn colTilausNumero = new DataGridTextColumn();
            DataGridTextColumn colTuoteNumero = new DataGridTextColumn();
            DataGridTextColumn colTuoteNimi = new DataGridTextColumn();
            DataGridTextColumn colMaara = new DataGridTextColumn();
            DataGridTextColumn colAHinta = new DataGridTextColumn();
            DataGridTextColumn colRivinSumma = new DataGridTextColumn();
            //Oliot sidotaan tietyn nimiseen sarakkeeseen < -- kohdistuu myöhemmin olion ominaisuuksiin, kunhan olio on ensin viety listalle
            colTilausRiviNumero.Binding = new Binding("TilausRiviNumero");
            colTilausNumero.Binding = new Binding("TilausNumero");
            colTuoteNumero.Binding = new Binding("TuoteNumero");
            colTuoteNimi.Binding = new Binding("TuoteNimi");
            colMaara.Binding = new Binding("Maara");
            colAHinta.Binding = new Binding("AHinta");
            colRivinSumma.Binding = new Binding("Summa");
            //DataGridin otsikot
            colTilausRiviNumero.Header = "Tilausrivin numero";
            colTilausNumero.Header = "Tilauksen numero";
            colTuoteNumero.Header = "Tuotenumero";
            colTuoteNimi.Header = "Tuotenimi";
            colMaara.Header = "Määrä";
            colAHinta.Header = "A-Hinta";
            colRivinSumma.Header = "Rivin summa";
            //Edellä "ilmaan" luotujen sarakkeiden sijoitus konkreettiseen DataGridiin, joka on luotu formille
            dgTilausRivit.Columns.Add(colTilausRiviNumero);
            dgTilausRivit.Columns.Add(colTilausNumero);
            dgTilausRivit.Columns.Add(colTuoteNumero);
            dgTilausRivit.Columns.Add(colTuoteNimi);
            dgTilausRivit.Columns.Add(colMaara);
            dgTilausRivit.Columns.Add(colAHinta);
            dgTilausRivit.Columns.Add(colRivinSumma);
        }
    
        private void HaeAsiakkaat() 
        {
            List<cbPairAsiakas> cbpairAsiakkaat = new List<cbPairAsiakas>(); //Luodaan olemassa olevien asiakasnimi-asiakasnumero-parien lista 
            TilausDBEntities entities = new TilausDBEntities(); 

            var asiakkaat = from a in entities.Asiakkaat 
                            select a; //Haetaan asiakkaat tietokannasta LINQ-kyselyllä

            foreach ( var asiakas in asiakkaat ) //Käydään kaikki asiakkaat läpi silmukassa
            { 
                cbpairAsiakkaat.Add(new cbPairAsiakas(asiakas.Nimi, asiakas.AsiakasID)); //Viedään asiakkaat listalle
            }
            cbAsiakas.DisplayMemberPath = "asiakasNimi"; //Kerrotaan pudotusvalikolle (ComboBox) mikä kenttä näytetään
            cbAsiakas.SelectedValuePath = "asiakasNro"; //Kerrotaan pudotusvalikolle (ComboBox) missä kentässä on arvotieto (joka siis viedään myöhemmin tietokantaan tilaukselle)
            cbAsiakas.ItemsSource = cbpairAsiakkaat; //Kerrotaan, että pudotusvalikon tietolähde on cbpairAsiakkaat-lista
        }

        private void HaeTuotteet()
        { 
            List<cbPairTuote> cbpairTuotteet = new List<cbPairTuote>();
            TilausDBEntities entities = new TilausDBEntities();

            var tuotteet = from t in entities.Tuotteet
                           select t;
            foreach ( var tuote in tuotteet )
            {
                cbpairTuotteet.Add(new cbPairTuote(tuote.Nimi, tuote.TuoteID));
            }
            cbTuote.DisplayMemberPath = "tuoteNimi";
            cbTuote.SelectedValuePath = "tuoteNro";
            cbTuote.ItemsSource = cbpairTuotteet;
        }

        private void btnLuoTilaus_Click(object sender, RoutedEventArgs e)
        {
            //Luodaan uusi Tilausotsikko-luokan olio jonka nimi on Tilaus. Luokan pohjalta luotuun olioon sijoitetaan käyttöliittymästä saatuja tietoja
            TilausOtsikko Tilaus = new TilausOtsikko();
            Tilaus.AsiakasNumero = int.Parse(txtAsiakasNumero.Text);//Tämä on poimittu ComboBoxista (cbPairAsiakas-olion avulla)
            Tilaus.ToimitusOsoite = txtToimitusOsoite.Text;
            Tilaus.Postinumero = txtPostinumero.Text;
            Tilaus.TilausPvm = dpTilausPvm.SelectedDate.Value;
            Tilaus.ToimitusPvm = dpToimitusPvm.SelectedDate.Value;

            txtToimitusAika.Text = Tilaus.LaskeToimitusAika();

            txtTilausNumero.Text = VieTilausKantaan(Tilaus); //Tässä tietojen vienti kantaan. Katso VieTilausKantaan() - rutiinin koodi alempaa
        }

        private string VieTilausKantaan(TilausOtsikko Tilaus)
        {
            try 
            {
                TilausDBEntities entities = new TilausDBEntities();
                Tilaukset dbItem = new Tilaukset() /*Luo Tilaukset-luokan dbItem-nimisen olion joka vastaa Tilaukset taulun sarakemäärityksiä. 
                                                    * Tilaukset löytyy entiteettimallin alta. Tietokantataulut löytyvät luokkamäärityksinä */
                {
                    AsiakasID = Tilaus.AsiakasNumero, //dbItemin asiakastietoon tulee Tilaus-olion asiakasnumero jne...
                    Toimitusosoite = Tilaus.ToimitusOsoite,
                    Postinumero = Tilaus.Postinumero,
                    Tilauspvm = Tilaus.TilausPvm,
                    Toimituspvm = Tilaus.ToimitusPvm
                };
                entities.Tilaukset.Add(dbItem);//Viedään dbItem Add-metodilla kantaan
                entities.SaveChanges(); //Tallenetaan. Näin lisätään uusia rivejä tietokantaan

                int id = dbItem.TilausID; //Haetaan juuri lisätyn rivin IDENTITEETTIsarakkeen arvo (eli PK)
                return id.ToString(); /*Palauttaa onnistuneen lisäyksen merkiksi uuden tilauksen numeron kutsuvalle ohjelmalle, 
                                       * eli viedään käyttöliittymän txtTilausNumero-tekstikenttään.*/
            }
            catch (Exception) 
            {
                return "0"; //Jos tallennus tietokantaan epäonnistuu, tämä rutiini palauttaa nollan
            }
            
        }

        private void cbAsiakas_DropDownClosed(object sender, EventArgs e) //Tämä eventti laukeaa aina, kun pudotusvalikko sulkeutuu
        {
            cbPairAsiakas cbp = (cbPairAsiakas)cbAsiakas.SelectedItem;/* Hakee valitun kohteen pudotusvalikosta ja muuntaa sen cbPairAsiakas-olioksi. Olio sisältää asiakasNimi ja
            asiakasNro - ominaisuudet jotka on alustettu HaeAsiakkaat - metodissa */
            string AsiakasNimi = cbp.asiakasNimi; //Hakee asiakasNimi-ominaisuuden arvon oliosta ja tallentaa sen AsiakasNimi-muuttujaan
            int AsiakasNro = cbp.asiakasNro; //Hakee asiakasNro ominaisuuden oliosta ja tallentaa sen AsiakasNro-muuttujaan 
            txtAsiakasNumero.Text = AsiakasNro.ToString();
        }

        private void cbTuote_DropDownClosed(object sender, EventArgs e)
        {
            cbPairTuote cbpt = (cbPairTuote)cbTuote.SelectedItem;
            string TuoteNimi = cbpt.tuoteNimi;
            int TuoteNro = cbpt.tuoteNro;
            txtTuoteNumero.Text = TuoteNro.ToString();
        }

        private void btnLisaaRivi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Luodaan uusi TilausRivi - luokan olio tilausRivi. Sama homma kun btnLuoTilaus_Clickissä
                TilausRivi tilausRivi = new TilausRivi();
                tilausRivi.TilausNumero = int.Parse(txtTilausNumero.Text);
                tilausRivi.TuoteNumero = int.Parse(txtTuoteNumero.Text);
                tilausRivi.TuoteNimi = cbTuote.Text;/*Gridiin tuodaan tuotteen nimi. Tietokantaan sitä ei viedä. Siksi on erikseen TilausRivi-luokka, ja tietokannan
                                                     Tilausrivit-luokka*/
                tilausRivi.Maara = int.Parse(txtMaara.Text);
                tilausRivi.AHinta = Convert.ToDecimal(txtAHinta.Text);

                tilausRivi.TilausRiviNumero = VieTilausRiviKantaan(tilausRivi);

                RivienSummaYht += tilausRivi.RiviSumma(); //Kuten tämä: RivinSummaYht = RivinSummaYht + TilausR.RiviSumma();
                txtRivienSumma.Text = RivienSummaYht.ToString();
                dgTilausRivit.Items.Add(tilausRivi);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    
        private int VieTilausRiviKantaan(TilausRivi TilausR) 
        {
            TilausDBEntities db = new TilausDBEntities();

            Tilausrivit dbItem = new Tilausrivit()
            {
                TilausID = TilausR.TilausNumero,
                TuoteID = TilausR.TuoteNumero,
                Maara = TilausR.Maara,
                Ahinta = TilausR.AHinta,
            };

            db.Tilausrivit.Add(dbItem);
            db.SaveChanges();

            int id = dbItem.TilausriviID;
            return id;
        }

        private void btnPostitoimipaikat_Click(object sender, RoutedEventArgs e)
        {
            formPostitoimiPaikat frmPostmp = new formPostitoimiPaikat();
            frmPostmp.Show();
        }

        private void btnSulje_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnTuotteet_Click(object sender, RoutedEventArgs e)
        {
            formTuotteet tuotteet = new formTuotteet();
            tuotteet.Show();
        }
    }
}
