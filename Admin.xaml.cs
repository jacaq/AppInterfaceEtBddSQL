using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Logique d'interaction pour Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        
        //BDD_northernEntities maBDD;

        public Admin()
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
           
            var query =
                from c in Acceuil.maBDD.Medecins
                select c ;
            DataGrid_ListeMedecins.DataContext = query.ToList();

        }

        private void btn_ajouter_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_id_med.Text) || !String.IsNullOrEmpty(tb_nom_med.Text) || !String.IsNullOrEmpty(tb_prenom_med.Text)) {

                

                String name, surname, the_id;

                surname = tb_nom_med.Text;
                name = tb_prenom_med.Text;
                the_id = tb_id_med.Text;


                Medecin un_med = new Medecin();

                //vérifit si id est libre d'utilisation
                var free_ID =
                    from c in Acceuil.maBDD.Medecins
                    where c.IDMedecin == the_id
                    select new { c.nom, c.prenom, c.IDMedecin };

                if (free_ID.Count() == 1)
                {
                    //MessageBox.Show("ID déjà utilisée, Choisir un autre ID");
                    MessageBox.Show("ID déjà utilisée, Choisir un autre ID", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else {
                    try
                    {
                        un_med.IDMedecin = the_id;
                        un_med.nom = surname;
                        un_med.prenom = name;

                        Acceuil.maBDD.Medecins.Add(un_med);
                        Acceuil.maBDD.SaveChanges();
                        //MessageBox.Show("Médecin ajouté avec succès!");
                        MessageBox.Show("Médecin ajouté avec succès!", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);

                        //A refaire pour le refresh
                        var query =
                            from c in Acceuil.maBDD.Medecins
                            select c;
                        DataGrid_ListeMedecins.DataContext = query.ToList();
                      
                    }
                    catch (Exception ex)
                    {

                        //MessageBox.Show(ex.Message);
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);

                    }


                }

                //Vidage des champs
                tb_nom_med.Text=String.Empty;
                tb_prenom_med.Text = String.Empty;
                tb_id_med.Text = String.Empty;



            }
        }

        private void btn_modifier_Click(object sender, RoutedEventArgs e)
        {
     
            Medecin mon_med = DataGrid_ListeMedecins.SelectedItem as Medecin;
            mon_med.nom=tb_nom_med.Text  ;
            mon_med.prenom=tb_prenom_med.Text;
            mon_med.IDMedecin=tb_id_med.Text;

            Acceuil.maBDD.SaveChanges();

            //A refaire pour le refresh
            var query =
                from c in Acceuil.maBDD.Medecins
                select c;
            DataGrid_ListeMedecins.DataContext = query.ToList();

        }

        private void DataGrid_ListeMedecins_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Medecin mon_med = DataGrid_ListeMedecins.SelectedItem as Medecin;
            tb_nom_med.Text = mon_med.nom;
            tb_prenom_med.Text = mon_med.prenom;
            tb_id_med.Text = mon_med.IDMedecin;

            //Permet l'option modification et annule l'option ajout
            btn_ajouter.IsEnabled = false;
            btn_modifier.IsEnabled = true;
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            //Vidage des champs
            tb_nom_med.Text = String.Empty;
            tb_prenom_med.Text = String.Empty;
            tb_id_med.Text = String.Empty;
            
            //Réinitialise les options des boutons ajout et modification
            btn_ajouter.IsEnabled = true;
            btn_modifier.IsEnabled = false;
        }
    }
}
