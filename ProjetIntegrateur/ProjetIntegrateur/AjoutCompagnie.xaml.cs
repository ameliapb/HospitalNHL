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
    /// Logique d'interaction pour AjoutCompagnie.xaml
    /// </summary>
    public partial class AjoutCompagnie : Window
    {
        public AjoutCompagnie()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Compagnie_Assurance comp = new Compagnie_Assurance();
            comp.nom_compagnie = txtNomComp.Text;
           

            MainWindow.myBDD.Compagnie_Assurance.Add(comp);
            try
            {
                MainWindow.myBDD.SaveChanges();
             //   RecherchePatient.NomComp = txtNomComp.Text;
               
                MessageBox.Show("Compagnie d'assurance ajoutée avec succès!");
                
                RecherchePatient.x1= MainWindow.myBDD.Compagnie_Assurance.Count();
                RecherchePatient a = new RecherchePatient();
               
                a.activer();
                a.ShowDialog();
                this.Hide();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            txtNomComp.Text = "";

        }

        private void btnAjout_Click(object sender, RoutedEventArgs e)
        {
            Compagnie_Assurance comp = new Compagnie_Assurance();
            comp.nom_compagnie = txtNomComp.Text;

            if (txtNomComp.Text == "")
            {
                MessageBox.Show("Veuillez remplir le nom de l'assurance!");
            }

            else
            {

                MainWindow.myBDD.Compagnie_Assurance.Add(comp);
                try
                {
                    MainWindow.myBDD.SaveChanges();
                    //   RecherchePatient.NomComp = txtNomComp.Text;

                    MessageBox.Show("Compagnie d'Assurance ajouté avec succee!");

                    RecherchePatient.x1 = MainWindow.myBDD.Compagnie_Assurance.Count();
                    RecherchePatient a = new RecherchePatient();

                    a.activer();
                    a.ShowDialog();
                    this.Hide();



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            RecherchePatient a = new RecherchePatient();
            a.activer();
            a.ShowDialog();
            this.Close();
        }
    }
}
