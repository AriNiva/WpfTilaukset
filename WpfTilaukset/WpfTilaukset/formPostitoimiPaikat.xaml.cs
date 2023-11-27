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
using System.Windows.Shapes;

namespace WpfTilaukset
{
    /// <summary>
    /// Interaction logic for formPostitoimiPaikat.xaml
    /// </summary>
    public partial class formPostitoimiPaikat : Window
    {
        TilausDBEntities dB = new TilausDBEntities();
        public formPostitoimiPaikat()
        {
            InitializeComponent();
            HaePostitoimipaikat();
        }
    
        private void HaePostitoimipaikat() 
        { 
            
            var postmpt = from posnot in dB.Postitoimipaikat
                          select posnot;

            dgPostitoimiPaikat.ItemsSource = postmpt.ToList();
        }

        private void btnLisaa_Click(object sender, RoutedEventArgs e)
        {
            Postitoimipaikat poss = new Postitoimipaikat();
            poss.Postinumero = txtPostiNumero.Text;
            poss.Postitoimipaikka = txtPostitoimipaikka.Text;
            dB.Postitoimipaikat.Add(poss);
            dB.SaveChanges();
            
            HaePostitoimipaikat();
        }


        private void btnTallenna_Click(object sender, RoutedEventArgs e)
        {
            dB.SaveChanges();
        }

        private void btnSulje_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Postitoimipaikat poss = dB.Postitoimipaikat.Find(txtPoistaPostinumero.Text);
            if (poss != null) 
            { 
                dB.Postitoimipaikat.Remove(poss);
                dB.SaveChanges();
            }
            HaePostitoimipaikat();
        }

        private void dgPostitoimiPaikat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgPostitoimiPaikat.SelectedIndex >= 0)
            {
                TextBlock PostiID = dgPostitoimiPaikat.Columns[0].GetCellContent(dgPostitoimiPaikat.Items[dgPostitoimiPaikat.SelectedIndex]) as TextBlock;
                if (PostiID != null)
                    txtPoistaPostinumero.Text = PostiID.Text;
                #region
                //TextBlock Postinumero = dgPostitoimiPaikat.Columns[1].GetCellContent(dgPostitoimiPaikat.Items[dgPostitoimiPaikat.SelectedIndex]) as TextBlock;
                //if (Postinumero != null)
                //    txtPoistaPostinumero.Text = Postinumero.Text;
                #endregion
                TextBlock Postitoimipaikka = dgPostitoimiPaikat.Columns[1].GetCellContent(dgPostitoimiPaikat.Items[dgPostitoimiPaikat.SelectedIndex]) as TextBlock;
                if (Postitoimipaikka != null)
                    txtPoistaPostitoimipaikka.Text = Postitoimipaikka.Text;
            }
        }
    }
}
