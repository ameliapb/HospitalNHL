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
    /// Logique d'interaction pour Tableau_Consultaion.xaml
    /// </summary>
    public partial class Tableau_Consultaion : Window
    {
        public static List<Patient> listeAdmis = new List<Patient>();
        public Tableau_Consultaion()
        {
            InitializeComponent();
        }
        public void Load()
        {

            var query =

         from c in MainWindow.myBDD.Patients
         join a in MainWindow.myBDD.Dossier_Admission on c.NSS equals a.NSS
         join b in MainWindow.myBDD.Parents on c.Ref_Parent equals b.Ref_Parent
         join l in MainWindow.myBDD.Lits on a.Numéro_Lit equals l.Numero_Lit
         join lt in MainWindow.myBDD.Type_Lit on l.numero_Type equals lt.Numero_Type

         select new { c.NSS, c.nom, c.prenom, c.telephone, a.date_admission, a.Numéro_Lit, a.date_chirurgie, a.date_conge, a.ID_Medecin,b.Ref_Parent,lt.description};
            if (query.ToList().Count == 0)
            {
                MessageBox.Show("aucun patient n'existe dans la base de données");
            }
            dgPatient.ItemsSource = query.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void dgPatient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnRecherchePatient_Click(object sender, RoutedEventArgs e)
        {
            if (txtNSS.Text == "")
            {
                MessageBox.Show("Vous devez remplir le champ NSS, svp!");
            }
            else
            {

            
            int nss = int.Parse(txtNSS.Text);
            var query =

         from c in MainWindow.myBDD.Patients
         join a in MainWindow.myBDD.Dossier_Admission on c.NSS equals a.NSS
         where c.NSS==nss
         select new { c.NSS, c.nom, c.prenom, c.telephone, a.date_admission, a.Numéro_Lit, a.date_chirurgie, a.date_conge, a.ID_Medecin };
            dgPatient.ItemsSource = query.ToList();
            }
        }

        private void btnTout_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void txtNSS_PreviewKeyDown(object sender, KeyEventArgs e)
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
