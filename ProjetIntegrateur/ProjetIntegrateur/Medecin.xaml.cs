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
    /// Logique d'interaction pour Medecin.xaml
    /// </summary>
    public partial class Medecin : Window
    {
        List<Patient> liseAdmi = new List<Patient>();

        public Medecin()
        {
            InitializeComponent();
        }

        private void cbPatient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          Patient patient = cbPatient.SelectedItem as Patient;
               txtNSS.Text =patient.NSS.ToString();
                txtNom.Text = patient.nom.ToString();
                txtPrenom.Text = patient.prenom.ToString();
                txtDateNais.Text = patient.date_naissance.ToString();
            foreach (Dossier_Admission d in MainWindow.myBDD.Dossier_Admission)
            {
                if (d.NSS == patient.NSS)
                {
                    txtNCH.Text = d.ID_Admission.ToString();
                    break;
                }
                
            }


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dateConge.SelectedDate = DateTime.Today;
            cbPatient.Text = "";

           
                foreach (Dossier_Admission d in MainWindow.myBDD.Dossier_Admission.ToList())
                {
                foreach (Patient p in MainWindow.myBDD.Patients.ToList()) {
                    if (d.NSS==p.NSS)
                    {
                        liseAdmi.Add(p);
                    }

                }

            }

          cbPatient.DataContext = liseAdmi;
        }

        private void btnDonnerConge_Click(object sender, RoutedEventArgs e)
        {
           int numlit = 0;
            try
            { 
                
                foreach (Dossier_Admission d in MainWindow.myBDD.Dossier_Admission) {
                   
                    if (d.ID_Admission==int.Parse(txtNCH.Text)) {
                        

                        d.date_conge = dateConge.SelectedDate;
                   
                      foreach (Lit l in MainWindow.myBDD.Lits)
                    {
                           
                            if (l.Numero_Lit==d.Numéro_Lit  )
                        {
                            
                                numlit = l.Numero_Lit;
                                break;
                               

                        }
                    }
                   
                    break;
                }
            }
                foreach (Lit l in MainWindow.myBDD.Lits)
                {
                   
                    if (l.Numero_Lit == numlit)
                    {
                    
                    l.occupe="0";
                        break;


                    }
                }

                MainWindow.myBDD.SaveChanges();
                MessageBox.Show("Congé donné avec succès!\n et le Lit numéro  "+numlit+"  a été liberé");
                vider();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boolean exist = true;
            try
            {
                int x = int.Parse(txtNSSR.Text);
                foreach (Patient p in liseAdmi)
                {
                    if (p.NSS == x)
                    {
                        exist = true;
                        txtNom.Text = p.nom.ToString();
                        txtPrenom.Text = p.prenom.ToString();
                        txtDateNais.Text = p.date_naissance.ToString();
                        txtNSS.Text = p.NSS.ToString();
                        //
                        //  int a= p.Dossier_Admission.ToString();
                        foreach (Dossier_Admission d in MainWindow.myBDD.Dossier_Admission)
                        {
                            if (d.NSS == p.NSS)
                            {
                                txtNCH.Text = d.ID_Admission.ToString();
                                break;
                            }

                            // x = p.NSS.ToString();
                        }
                        break;
                    }
                    else
                    {
                        exist = false;
                    }

                }
                if (exist == false)
                {
                    MessageBox.Show("Le patient n'existe pas !!!! \n ou le patient n'a pas de dossier d'admission ");


                    vider();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez remplir le champs de recherche");
            }

            
    
        }
        public void vider()
        {
            txtNSS.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtNCH.Text = "";
            txtDateNais.Text = "";
           

        }

        private void groupBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNSSR_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                if (e.Key < Key.NumPad0 || e.Key > Key.NumPad9)
                {
                    if ((e.Key != Key.Back) && (e.Key != Key.Tab)  && (e.Key != Key.OemComma))
                    {
                        e.Handled = true;
                        MessageBox.Show("J'accepte uniquement les chiffres", "Erreur", MessageBoxButton.OK);
                    }
                }
            }
        }
    }
}
