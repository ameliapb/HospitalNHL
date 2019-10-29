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
    /// Logique d'interaction pour AjoutParent.xaml
    /// </summary>
    public partial class AjoutParent : Window
    {
        public AjoutParent()
        {
            InitializeComponent();
        }

    

        private void btnAjoutParent_Click(object sender, RoutedEventArgs e)
        {
            if (txtNom.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Le nom et le numéro de téléphone sont obligatoires");
            }
            else
            {

                Parent parent = new Parent();
                parent.nom = txtNom.Text;
                parent.prenom = txtPrenom.Text;
                parent.adresse = txtAdr.Text;
                parent.ville = txtVille.Text;
                parent.province = txtProvince.Text;
                parent.code_postal = txtCP.Text;
                parent.telephone = txtTel.Text;



                MainWindow.myBDD.Parents.Add(parent);
                try
                {
                    MainWindow.myBDD.SaveChanges();
                    //   RecherchePatient.NomComp = txtNomComp.Text;

                    MessageBox.Show("Parent ajouté avec succès!");

                    RecherchePatient.x1 = RecherchePatient.idexComp + 1;
                    RecherchePatient.indexParent = MainWindow.myBDD.Parents.Count();
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

        private void txtTel_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                //Détermine si la séquence de touches est un nombre du clavier.
                if (e.Key < Key.NumPad0 || e.Key > Key.NumPad9)
                {
                    if ((e.Key != Key.Back) && (e.Key != Key.Tab) && (e.Key != Key.OemComma))
                    {
                        e.Handled = true;
                        MessageBox.Show("J'accepte uniquement les chiffres, désolé.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
            }
        }
    }
}
