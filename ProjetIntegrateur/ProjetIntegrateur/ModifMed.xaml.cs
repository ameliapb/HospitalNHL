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
    /// Logique d'interaction pour ModifMed.xaml
    /// </summary>
    public partial class ModifMed : Window
    {
        public ModifMed()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
         cbMed.ItemsSource = MainWindow.myBDD.MedecinTs.ToList();
            MedecinT medecin = cbMed.SelectedItem as MedecinT;
            txtNom.Text = medecin.nom.ToString();
            txtPrenom.Text = medecin.prenom.ToString();
            txtSpecialite.Text = medecin.specialite.ToString();

        }

        private void cbPatient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbMed.Text != "")
            {
               

                MedecinT medecin = cbMed.SelectedItem as MedecinT;

                txtNom.Text = medecin.nom.ToString();
                txtPrenom.Text = medecin.prenom.ToString();
               
                txtSpecialite.Text = medecin.specialite.ToString();
              

            }
        }

        private void btnModif_Click(object sender, RoutedEventArgs e)
        {
            MedecinT medecin = cbMed.SelectedItem as MedecinT;
            if (medecin != null)
            {

                var resultat = MessageBox.Show("Êtes-vous certain de vouloir modifier le médecin:  " + medecin.nom + " " +

                            medecin.prenom, "Attention", MessageBoxButton.YesNo,
                            MessageBoxImage.Question);
                if (resultat == MessageBoxResult.Yes)
                {

                    medecin.nom = txtNom.Text.ToString();
                    medecin.prenom = txtPrenom.Text.ToString();
                    medecin.specialite = txtSpecialite.Text.ToString();


                    try
                    {
                        MainWindow.myBDD.SaveChanges();

                        MessageBox.Show("Médecin modifiée avec succès!");
                    

                       
                        vider();
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
        public void vider()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtSpecialite.Text = "";
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            Personnel p = new Personnel();
            p.Show();
            this.Close();
        }
    }
}
