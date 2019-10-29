using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Logique d'interaction pour RecherchePatient.xaml
    /// </summary>
    public partial class RecherchePatient : Window
    {
        public static int x1 = 0, idexComp, indexParent = 0;

        public static List<Patient> pasNA = new List<Patient>();
        public static string nomCompa, x, nom = "", prenom = "", nss = "", tel = "", adr = "", ville = "", province = "", CP = "", NomComp = "",dateN="";
        public RecherchePatient()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Boolean exist = true;

            int x = int.Parse(txtNSSR.Text);
            if (MainWindow.myBDD.Patients.Count()==0) {
                exist = false;

            }
            else {
                foreach (Patient p in MainWindow.myBDD.Patients)
                {
                    if (p.NSS == x)
                    {
                        exist = true;
                        txtNom.Text = p.nom.ToString();
                        txtPrenom.Text = p.prenom.ToString();
                        DateNais.Text = p.date_naissance.ToString();
                        txtNSS.Text = p.NSS.ToString();
                        //  x = p.NSS.ToString();

                        break;
                    }
                    else
                    {
                        exist = false;
                    }

                } }
            if (exist == false)
            {
                MessageBox.Show("le patient n'existe pas !!!!\n veuillez l'inscrire tout d'adord");
                activer();
                cbComp.DataContext = MainWindow.myBDD.Compagnie_Assurance.ToList();

                vider();

            }
        }
        public void activer()
        {
            txtNSS.IsHitTestVisible = true;
            txtNom.IsHitTestVisible = true;
            txtPrenom.IsHitTestVisible = true;
            DateNais.IsHitTestVisible = true;
            txtTel.IsHitTestVisible = true;
            txtAdresse.IsHitTestVisible = true;
            txtVille.IsHitTestVisible = true;
            txtProvince.IsHitTestVisible = true;
            txtCodePostale.IsHitTestVisible = true;
            cbComp.IsEnabled = true;
         
            cbParent.IsEnabled = true;
            btnAjoutComp.IsEnabled = true;
            btnAjoutParent.IsEnabled = true;
            btnEnregistrer.IsEnabled = true;
            //  btnAdmetHop.IsEnabled = true;
            load();


        }
        public void desactiver()
        {
            txtNSS.IsHitTestVisible = false;
            txtNom.IsHitTestVisible = false;
            txtPrenom.IsHitTestVisible = false;
            DateNais.IsHitTestVisible = false;
            txtTel.IsHitTestVisible = false;
            txtAdresse.IsHitTestVisible = false;
            txtVille.IsHitTestVisible = false;
            txtProvince.IsHitTestVisible = false;
            txtCodePostale.IsHitTestVisible = false;
            cbComp.IsEnabled = false;
            cbParent.IsEnabled = false;
            btnAjoutComp.IsEnabled = false;
            btnAjoutParent.IsEnabled = false;
            btnEnregistrer.IsEnabled = false;
            btnAdmetHop.IsEnabled = false;
            //  load();


        }
        public void vider()
        {
            txtNSS.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            DateNais.Text = "";
            txtAdresse.Text = "";
            txtVille.Text = "";
            txtProvince.Text = "";
            txtCodePostale.Text = "";

        }

        private void cbPatient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void txtNSS_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAdmetHop_Click(object sender, RoutedEventArgs e)
        {
            ProcessusAdmission.nom = txtNom.Text;
            ProcessusAdmission.prenom = txtPrenom.Text;
            ProcessusAdmission.NSS = txtNSS.Text;

            ProcessusAdmission p = new ProcessusAdmission();

            p.ShowDialog();
        }

        private void txtNSSR_PreviewKeyDown(object sender, KeyEventArgs e)
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

        private void cbPatient_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (cbPatient.Text != "")
            {
                desactiver();

                Patient patient = cbPatient.SelectedItem as Patient;

                txtNom.Text = patient.nom.ToString();
                txtPrenom.Text = patient.prenom.ToString();
                btnAdmetHop.IsEnabled = true;
                DateNais.Text = patient.date_naissance.ToString();
                txtNSS.Text = patient.NSS.ToString();
                DateNais.Text = patient.date_naissance.ToString();
                txtTel.Text = patient.telephone.ToString();
                txtAdresse.Text = patient.adresse.ToString();
                txtVille.Text = patient.ville.ToString();
                txtProvince.Text = patient.province.ToString();
                txtCodePostale.Text = patient.code_postal.ToString();


                int idC = (int)patient.IDCompagnie;

                int idP = (int)patient.Ref_Parent;
                var query =

         from c in MainWindow.myBDD.Compagnie_Assurance
         where c.ID_compagnie == idC
         select new { c.nom_compagnie };
                cbComp.DataContext = query.ToList();
                var query1 =

        from p in MainWindow.myBDD.Parents
        where p.Ref_Parent == idP
        select new { p.nom };
                cbParent.DataContext = query1.ToList();



            }
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           // nom = prenom = nss = tel = adr = ville = province = CP = NomComp = "";
            MainWindow rp = new MainWindow();
            rp.Show();

            this.Hide();



        }

        private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
        {

            Boolean exist = false;
            if (txtNSS.Text == "" || txtNom.Text == "" || txtPrenom.Text == "" || DateNais.Text == "" || txtTel.Text == "" || txtAdresse.Text == "" || txtVille.Text == "" || txtProvince.Text == "" || txtCodePostale.Text == "" || txtCodePostale.Text == "" || cbParent.Text == "")
            {




                MessageBox.Show("Veuillez remplir tous les champs ");

            }
            else if (!Regex.Match(txtTel.Text, @"[0-9]{10}$").Success)
            {
                MessageBox.Show("Veuillez verifier le téléphone.\n Format incorrect il doit être 5555555555 (10 chiffres)", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }


            else
            {
                foreach (Patient p1 in MainWindow.myBDD.Patients)
                {
                    if (p1.NSS == int.Parse(txtNSS.Text))
                    {
                        exist = true;
                        break;
                    }
                }
                if (exist == true)
                {
                    MessageBox.Show("Le NSS existe déjà !!!!!!!!!!!!!!!!");
                }
                else
                {
                    Patient patient = new Patient();

                    patient.NSS = int.Parse(txtNSS.Text);

                    patient.nom = txtNom.Text;

                    patient.prenom = txtPrenom.Text;  

                    patient.adresse = txtAdresse.Text;

                    patient.telephone = txtTel.Text;

                    patient.ville = txtVille.Text;

                    patient.province = txtProvince.Text;

                    patient.code_postal = txtCodePostale.Text;

                    if (cbComp.Text != "")
                    {
                        Compagnie_Assurance CA = cbComp.SelectedItem as Compagnie_Assurance;


                        patient.IDCompagnie = CA.ID_compagnie;
                    }

                    if (cbParent.Text != "")
                    {
                        Parent p = cbParent.SelectedItem as Parent;

                        patient.Ref_Parent = p.Ref_Parent;
                    }

                    if (DateNais.SelectedDate > DateTime.Today)
                    {
                        MessageBox.Show("La date de naissance est incorrecte!!!");
                    }
                    else
                    {
                        patient.date_naissance = DateNais.SelectedDate;

                        MainWindow.myBDD.Patients.Add(patient);
                        btnAdmetHop.IsEnabled = true;

                        try
                        {
                            MainWindow.myBDD.SaveChanges();
                            MessageBox.Show("Patient ajouté avec succès!");
                            cbPatient.DataContext = MainWindow.myBDD.Patients.ToList();

                            //  vider();
                            // load();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }


        }

        private void cbComp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            idexComp = cbComp.SelectedIndex;
        }

        private void cbParent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtNom_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            desactiver();
            btnRecherche.IsEnabled = true;
        }

        private void txtNSS_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void btnAjoutComp_Click(object sender, RoutedEventArgs e)
        {
            SauvDonnee();


            AjoutCompagnie a = new AjoutCompagnie();
            a.ShowDialog();
            this.Hide();

        }
        public void SauvDonnee()
        {
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            nss = txtNSS.Text;
            tel = txtTel.Text;
            adr = txtAdresse.Text;
            ville = txtVille.Text;
            province = txtProvince.Text;
            CP = txtCodePostale.Text;
            dateN = DateNais.Text;

        }

        private void btnAjoutParent_Click(object sender, RoutedEventArgs e)
        {
            SauvDonnee();
            NomComp = cbComp.Text;
            AjoutParent a = new AjoutParent();
            a.Show();
            this.Hide();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            load();



        }
        public void load()
        {
            cbPatient.Text = "";
            cbPatient.DataContext = null;
            cbPatient.DataContext = MainWindow.myBDD.Patients.ToList();
            cbComp.DataContext = MainWindow.myBDD.Compagnie_Assurance.ToList();
            cbParent.DataContext = MainWindow.myBDD.Parents.ToList();
            cbComp.SelectedIndex = x1 - 1;
            cbParent.SelectedIndex = indexParent - 1;
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtNSS.Text = nss;
            txtTel.Text = tel;
            txtAdresse.Text = adr;
            txtVille.Text = ville;
            txtProvince.Text = province;
            txtCodePostale.Text = CP;
            DateNais.Text = dateN;

        }


    }
}
