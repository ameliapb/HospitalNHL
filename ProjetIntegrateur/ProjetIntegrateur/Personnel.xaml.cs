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

namespace ProjetIntegrateur
{
    /// <summary>
    /// Logique d'interaction pour Personnel.xaml
    /// </summary>
    public partial class Personnel : Window
    {
        public static List<MedecinT> med = new List<MedecinT>();
        public Personnel()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

      
        public void rafraichir()
        {
    

               dgMedecin.ItemsSource = MainWindow.myBDD.MedecinTs.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

             rafraichir();


        }

        private void btnSupp_Click(object sender, RoutedEventArgs e)
        {
            MedecinT medecin = dgMedecin.SelectedItem as MedecinT;
 if (medecin != null)
               {
                   
       var resultat = MessageBox.Show("Êtes-vous certain de vouloir supprimer le médecin: " + medecin.nom + " " +

                   medecin.prenom, "Attention", MessageBoxButton.YesNo,
                   MessageBoxImage.Question);
                   if (resultat == MessageBoxResult.Yes)
                   {
  MainWindow.myBDD.MedecinTs.Remove(medecin);
                    try
                    {
                        MainWindow.myBDD.SaveChanges();
                         MessageBox.Show("Médecin a été supprimé avec succès!");
                       rafraichir();
                        //vider();
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show(ex.Message);
                    }
                }
       }
       else
       {
           MessageBox.Show("Vous devez sélectionner un médecin.", "Erreur",
           MessageBoxButton.OK, MessageBoxImage.Error);
       }
        }


        private void btnModif_Click(object sender, RoutedEventArgs e)
        {
            ModifMed m = new ModifMed();
            m.Show();
            this.Close();
           
            }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

       
        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnConsulation_Click(object sender, RoutedEventArgs e)
        {
            Tableau_Consultaion t = new Tableau_Consultaion();
            t.ShowDialog();
        }

        private void dgMedecin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgMedecin_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnAjout_Click(object sender, RoutedEventArgs e)
        {
            AjoutMed a = new AjoutMed();
            a.Show();
            this.Close();
        }
    }
}
