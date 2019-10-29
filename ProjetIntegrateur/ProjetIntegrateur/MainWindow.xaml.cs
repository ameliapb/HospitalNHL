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

namespace ProjetIntegrateur
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static NLHEntities1 myBDD;
        public MainWindow()
        {
            InitializeComponent();
            myBDD = new NLHEntities1();
        
            txtUser.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            string x = txtUser.Text;
            string y = txtmotPass.Password;
            if (x == "Admin" && y == "admin")
            {
                Personnel a = new Personnel();
                a.ShowDialog();

            }
            else if (x == "Medecin" && y == "medecin")
            {
                Medecin m = new Medecin();
                m.ShowDialog();

            }
            else if (x == "Préposé" && y == "prepose")
            {

                RecherchePatient rp = new RecherchePatient();
                rp.ShowDialog();

            }
            else
            {
                MessageBox.Show("Le mot de passe ou le nom utilisateur sont incorrects");
            }

        }

        private void btnQuitter_Click_1(object sender, RoutedEventArgs e)
        {
  this.Close();
        }
    }


    
    }

