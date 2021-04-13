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

namespace Anagrafica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nome.Text != "" || txt_cognome.Text != "" || txt_eta.Text != "")
            {
                try
                {
                    string nome = txt_nome.Text;
                    string cognome = txt_cognome.Text;
                    int eta = int.Parse(txt_eta.Text);
                    string preferito = "";
                    string preferenza2 = "";
                    if (eta < 20)
                        MessageBox.Show("inserire un eta pari o superiore hai venti", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                    if (rdb_calcio.IsChecked == true)
                    {
                        Lbl_domanda.Content = "quale è la tua squadra preferita";
                        cbx_r1.Content = "juve";
                        cbx_rb2.Content = "milan";
                        cbx_r3.Content = "inter";
                        preferito = "calcio";
                        if (cbx_r1.IsChecked == true)
                            preferenza2 = $"{cbx_r1.Content}";
                        else if (cbx_rb2.IsChecked == true)
                            preferenza2 = $"{cbx_rb2.Content}";
                        else
                            preferenza2 = $"{cbx_r3.Content}";
                    }
                    else if (rdb_nuoto.IsChecked == true)
                    {
                        Lbl_domanda.Content = "quale è il tuo stile preferito";
                        cbx_r1.Content = "rana";
                        cbx_rb2.Content = "dorso";
                        cbx_r3.Content = "delfino";
                        preferito = "nuoto";
                        if (cbx_r1.IsChecked == true)
                            preferenza2 = $"{cbx_r1.Content}";
                        else if (cbx_rb2.IsChecked == true)
                            preferenza2 = $"{cbx_rb2.Content}";
                        else
                            preferenza2 = $"{cbx_r3.Content}";
                    }
                    else
                    {
                        Lbl_domanda.Content = "quale è il tuo pallavolista preferito";
                        cbx_r1.Content = "tommaso";
                        cbx_rb2.Content = "luca";
                        cbx_r3.Content = "Miglio";
                        preferito = "pallavolo";
                        if (cbx_r1.IsChecked == true)
                            preferenza2 = $"{cbx_r1.Content}";
                        else if (cbx_rb2.IsChecked == true)
                            preferenza2 = $"{cbx_rb2.Content}";
                        else
                            preferenza2 = $"{cbx_r3.Content}";
                    }
                    MessageBox.Show($"l'utente {nome} {cognome} di età {eta}\nha come sport preferito {preferito} e come seconda preferenza {preferenza2}"
                        , "RIEPILOGO", MessageBoxButton.OK);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ATTENZIONE NON TUTTI I DATI RICHIESTI SONO STATI INSERITI", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
