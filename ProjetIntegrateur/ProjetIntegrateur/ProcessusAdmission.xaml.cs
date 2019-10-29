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
    /// Logique d'interaction pour ProcessusAdmission.xaml
    /// </summary>
    public partial class ProcessusAdmission : Window
    {
        public static string nom, prenom, NSS;
        public ProcessusAdmission()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Boolean active = true;

            dateAdmission.SelectedDate = DateTime.Today;
            txtNom.Text = nom;
            txtPrenom.Text = prenom;

            txtNSS.Text = NSS;
            if (MainWindow.myBDD.Lits.Count() == 0)
            {
                MessageBox.Show("Il n'y a pas de lit disponnible à l'hopital !!!");
            }else  if (rbPublic.IsChecked == true)
            {
                var query =

                                  from c in MainWindow.myBDD.Lits
                                  where c.occupe == "0" && c.numero_Type == 18
                                  select new { c.ID_Departement, c.Numero_Lit, c.numero_Type };
                if (query.ToList().Count == 0)
                {
                    MessageBox.Show("Il n'y a pas de lit public disponnible à l'hopital!!!! ");
                    active = false;

                }
                cbLit.DataContext = query.ToList();


            }
            if(MainWindow.myBDD.MedecinTs.Count() == 0) 
                {
                    MessageBox.Show("Il n'y a pas de medecin disponnible a l'hopital !!!!");
                active = false;
            }
                else
                    cbMedecin.DataContext = MainWindow.myBDD.MedecinTs.ToList();
            if (active == true)
            {
                btnValider.IsEnabled = true;
            }


        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            Dossier_Admission dossier =   new Dossier_Admission();
            string ChP = "0";
            
            if (ChuPche.IsChecked==true)
            {
                ChP = "1";
             
            }
            dossier.chirurgie_programme= ChP;
           dossier.NSS =int.Parse(txtNSS.Text);
       
            
          dossier.Numéro_Lit = int.Parse(cbLit.Text);

          

            dossier.date_admission = dateAdmission.SelectedDate;
           
            dossier.date_chirurgie = DateChurirgie.SelectedDate;
            MedecinT med = cbMedecin.SelectedItem as MedecinT;
            
          dossier.ID_Medecin = med.ID_Medecin;



            MainWindow.myBDD.Dossier_Admission.Add(dossier);
            try
            {
              
                foreach (Lit l in MainWindow.myBDD.Lits)
                {
                    if (l.Numero_Lit==int.Parse(cbLit.Text))
                    {
                        l.occupe = "1";
                    }

                }
             //   vider();
                MainWindow.myBDD.SaveChanges();
                MessageBox.Show("Dossier d'admission ajouté avec succès!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void cbMedecin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
 
           
        }

        private void cbLit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ChuPche_Checked(object sender, RoutedEventArgs e)
        {
           
          
        }

        private void ChuPche_Click(object sender, RoutedEventArgs e)
        {
            if(ChuPche.IsChecked==true)
            DateChurirgie.IsEnabled = true;
            else
                DateChurirgie.IsEnabled = false;
        }

        private void rbPublic_Checked(object sender, RoutedEventArgs e)
        {
                  
                var query =

                                   from c in MainWindow.myBDD.Lits
                                   where c.occupe == "0" && c.numero_Type == 18
                                   select new { c.ID_Departement, c.Numero_Lit, c.numero_Type };
                if (query.ToList().Count == 0)
                {
                    MessageBox.Show("Il n'y a pas de lit Public disponnible a l'hopital ");
           
    }
            cbLit.DataContext = query.ToList();


        }

        private void rbSPublic_Checked(object sender, RoutedEventArgs e)
        {
            var query1 =

                                 from c in MainWindow.myBDD.Lits
                                 where c.occupe == "0" && c.numero_Type == 17
                                 select new { c.ID_Departement, c.Numero_Lit, c.numero_Type };
            if (query1.ToList().Count == 0)
            {

                MessageBox.Show("Il n'y a pas de lit semi public disponnible a l'hopital ");
       
            }
          

        }

        private void rbSPublic_Click(object sender, RoutedEventArgs e)
        {
            var query =

                                from c in MainWindow.myBDD.Lits
                                where c.occupe == "0" && c.numero_Type == 17
                                select new { c.ID_Departement, c.Numero_Lit, c.numero_Type };
            if (query.ToList().Count == 0)
            {
                MessageBox.Show("Il n'y a pas de lit semi public disponnible a l'hopital ");

              

            }
          
           
                cbLit.DataContext = query.ToList();
            

        }

        private void rbPrive_Click(object sender, RoutedEventArgs e)
        {
            var query =

                                from c in MainWindow.myBDD.Lits
                                where c.occupe == "0" && c.numero_Type == 16
                                select new { c.ID_Departement, c.Numero_Lit, c.numero_Type };
            if (query.ToList().Count == 0)
            {
                MessageBox.Show("Il n'y a pas de lit privé disponnible a l'hopital ");
              
            }
            
                cbLit.DataContext = query.ToList();
            

        }

        public void vider()
        {
            ChuPche.IsChecked= false;
            dateAdmission.SelectedDate = DateTime.Today;
           
            txtNSS.Text = "";
            cbLit.SelectedIndex = -1;
            cbMedecin.SelectedIndex = -1;
          
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
