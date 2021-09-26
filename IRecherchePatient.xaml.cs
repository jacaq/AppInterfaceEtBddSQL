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
    /// Logique d'interaction pour IRecherchePatient.xaml
    /// </summary>
    public partial class IRecherchePatient : Window
    {
        public IRecherchePatient()
        {
            InitializeComponent();
        }

        private void btn_rechercher_patient_Click(object sender, RoutedEventArgs e)
        {
            String le_nas;
            if (!String.IsNullOrEmpty(tb_nas_patient.Text))
            {

                le_nas = tb_nas_patient.Text;
                
                //faire la recherche dans la BDD
               
                var recherche =
                       from c in Acceuil.maBDD.Patients where c.NAS==le_nas
                       select new { c.Nom, c.Prenom, c.NAS, c.Adresse_civique, c.App, c.Ville, c.Province, c.Code_postal, c.Telephone, c.Date_naissance, c.IDAssurance };
                    DataGrid_listePatient.DataContext = recherche.ToList();

                if (recherche.Count() != 1) {
                    //MessageBox.Show("Aucun Patient n'existe avec ce NAS: vérifier le format 555-555-555");
                    MessageBox.Show("Aucun Patient n'existe avec ce NAS: vérifier le format 555-555-555", "Errer du nas", MessageBoxButton.OK, MessageBoxImage.Information);

                }


            }
            else {
                //MessageBox.Show("Remplisser le champs NAS");
                MessageBox.Show("Remplisser le champs NAS", "Champs vide", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void btn_retour_Click(object sender, RoutedEventArgs e)
        {
            Preposee fenetre_preposse = new Preposee();
            fenetre_preposse.Show();
            this.Close();
        }
    }
}
