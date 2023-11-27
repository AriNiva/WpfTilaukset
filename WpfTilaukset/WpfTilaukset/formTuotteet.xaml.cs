using System;
using System.Collections.Generic;
using System.Data.Common;
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
using System.Windows.Shapes;

namespace WpfTilaukset
{
    /// <summary>
    /// Interaction logic for formTuotteet.xaml
    /// </summary>
    public partial class formTuotteet : Window
    {
        TilausDBEntities db = new TilausDBEntities();
        string dbMode = "";
        public formTuotteet()
        {
            InitializeComponent();
            HaeTuotteet();
        }

        private void HaeTuotteet() 
        { 
            List<Tuote> lstTuotteet = new List<Tuote>();

            var tuoteLuettelo = from t in db.Tuotteet
                                select t;
            foreach (Tuotteet tuote in tuoteLuettelo)
            {
                Tuote yksiTuote = new Tuote();
                yksiTuote.TuoteID = tuote.TuoteID.ToString();
                yksiTuote.Nimi = tuote.Nimi;
                yksiTuote.Ahinta = tuote.Ahinta.ToString();
                yksiTuote.Kuva = tuote.Kuva;
                lstTuotteet.Add(yksiTuote);
            }

            dgTuotteet.ItemsSource = lstTuotteet;

            txtTuoteID.IsEnabled = false;
            txtNimi.IsEnabled = false;
            txtAHinta.IsEnabled = false;
            btnTallenna.IsEnabled = false;
            dbMode = "";
        }

        private void btnSulje_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLisaa_Click(object sender, RoutedEventArgs e)
        {
            txtTuoteID.IsEnabled=false;
            txtNimi.IsEnabled=true;
            txtAHinta.IsEnabled=true;
            btnTallenna.IsEnabled=true;

            txtTuoteID.Text = "";
            txtNimi.Text = "";
            txtAHinta.Text = "";
            dbMode = "ADD";
        }

        private void btnTallenna_Click(object sender, RoutedEventArgs e)
        {
            if (dbMode == "EDIT")
            {
                MuokkaaTietokantaa();
            }
            else if (dbMode == "ADD")
            {
                LisaaTietokantaan();
            }
            else 
            { 
                //
            }
            db.SaveChanges();
            HaeTuotteet();
        }

        private void dgTuotteet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgTuotteet.SelectedIndex >= 0)
            {
                TextBlock TuoteID = dgTuotteet.Columns[0].GetCellContent(dgTuotteet.Items[dgTuotteet.SelectedIndex]) as TextBlock;
                if (TuoteID != null) txtTuoteID.Text = TuoteID.Text;
                
                TextBlock Nimi = dgTuotteet.Columns[1].GetCellContent(dgTuotteet.Items[dgTuotteet.SelectedIndex]) as TextBlock;
                if (Nimi != null) txtNimi.Text = Nimi.Text;

                TextBlock Ahinta = dgTuotteet.Columns[2].GetCellContent(dgTuotteet.Items[dgTuotteet.SelectedIndex]) as TextBlock;
                if (Ahinta != null) txtAHinta.Text = Ahinta.Text;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Tuotteet tuote = db.Tuotteet.Find(int.Parse(txtTuoteID.Text));
            if (tuote != null) 
            { 
                db.Tuotteet.Remove(tuote);
                db.SaveChanges();
            }
            HaeTuotteet();
        }
    
        private void MuokkaaTietokantaa()
        {
            Tuotteet prod = db.Tuotteet.Find(int.Parse(txtTuoteID.Text));
            if (prod != null) 
            { 
                prod.Nimi = txtNimi.Text;
                prod.Ahinta = decimal.Parse(txtAHinta.Text);
                db.SaveChanges();
            }
            HaeTuotteet();
        }
    
        private void LisaaTietokantaan() 
        {
            Tuotteet prod = new Tuotteet();
            prod.Nimi = txtNimi.Text;
            prod.Ahinta = decimal.Parse(txtAHinta.Text);
            db.Tuotteet.Add(prod);
            db.SaveChanges();
            HaeTuotteet();
        }

        private void btnMuokkaa_Click(object sender, RoutedEventArgs e)
        {
            txtTuoteID.IsEnabled = false;
            txtNimi.IsEnabled = true;
            txtAHinta.IsEnabled = true;
            btnTallenna.IsEnabled = true;
            dbMode = "EDIT";
        }
    }
}
