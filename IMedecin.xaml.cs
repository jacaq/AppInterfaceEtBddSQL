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

namespace tp01_cSharp
{
    /// <summary>
    /// Logique d'interaction pour Medecin.xaml
    /// </summary>
    public partial class IMedecin : Window
    {
       

        public IMedecin()
        {
            InitializeComponent();
        }

        private void btn_Acceuil_Click(object sender, RoutedEventArgs e)
        {
            Acceuil fenetre_acceuil = new Acceuil();
            fenetre_acceuil.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            //remplir datagrid avec une query
           /* var query =
            from c in Acceuil.maBDD.Patients
            select new { c.Nom, c.Prenom, c.NAS, c.Adresse_civique, c.App, c.Ville, c.Province, c.Code_postal, c.Telephone, c.Date_naissance, c.IDAssurance };
            DataGrid_listePatient.DataContext = query.ToList();*/

            DataGrid_listePatient.DataContext = Acceuil.maBDD.Patients.ToList();
            
        }

        

        

        private void btn_donnerConger_Click(object sender, RoutedEventArgs e)
        {

            Patient mon_patient = DataGrid_listePatient.SelectedItem as Patient;
            String le_NAS = mon_patient.NAS;
            

            Admission ad_patient= (from c in Acceuil.maBDD.Admissions
                                   where c.NAS==le_NAS
                                   select c).FirstOrDefault();
            if (ad_patient != null)
            {
                ad_patient.date_congee= DateTime.Now;
                Acceuil.maBDD.SaveChanges();
                //MessageBox.Show("Congé du patient ajouté avec succès!");
                MessageBox.Show("Congé du patient ajouté avec succès!", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else {
                //MessageBox.Show("Erreur: Patient n'existe pas");
                MessageBox.Show("Erreur: Patient n'existe pas", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Acceuil.maBDD.SaveChanges();

            //refresh
            var query =
                from c in Acceuil.maBDD.Patients
                select c;
            DataGrid_listePatient.DataContext = query.ToList();

          
        }
    }
}
