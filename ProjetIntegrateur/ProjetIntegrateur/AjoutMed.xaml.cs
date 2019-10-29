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
    /// Logique d'interaction pour AjoutMed.xaml
    /// </summary>
    public partial class AjoutMed : Window
    {
        public AjoutMed()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, RoutedEventArgs e)
        {
            if (txtNom.Text == "" || txtPrenom.Text == "" || txtSpecialite.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs!");
            }
            else
            {
                MedecinT medecin = new MedecinT();
                medecin.nom = txtNom.Text;
                medecin.prenom = txtPrenom.Text;
                medecin.specialite = txtSpecialite.Text;


                MainWindow.myBDD.MedecinTs.Add(medecin);
                try
                {
                    MainWindow.myBDD.SaveChanges();
                    MessageBox.Show("Médecin ajouté avec succès!");


                    vider();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void vider()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtSpecialite.Text = "";
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            vider();
        }

        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            Personnel p = new Personnel();
            p.Show();
            this.Close();
        }
    }
}
