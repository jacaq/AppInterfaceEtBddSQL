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
    /// Logique d'interaction pour IAdmission.xaml
    /// </summary>
    public partial class IAdmission : Window
    {
        public IAdmission()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            
            //datepickers à la date d'aujourd'hui
            datePicker_admission.SelectedDate = DateTime.Now;
            datePicker_chirurgie.SelectedDate = DateTime.Now;

            
            checkbox_TV.IsChecked = false;
            checkbox_telephone.IsChecked = false;
        }

        private void btn_confirmerAdmission_Click(object sender, RoutedEventArgs e)
        {
            bool chirurgie_prog=false, TV,TEL;
            String date_admin, date_chirurgie;

            //Chirurgie programmée ? OUI/NON
            if (radio_oui.IsChecked==true || radio_non.IsChecked==true) {
                if (radio_oui.IsChecked == true)
                    chirurgie_prog = true;
                else chirurgie_prog = false;
            }
            //Les dates
            date_admin = datePicker_admission.ToString();
            date_chirurgie = datePicker_chirurgie.ToString();

            //Les services
            if (checkbox_TV.IsChecked == true) TV = true;
            else TV = false;
            if (checkbox_telephone.IsChecked == true) TEL = true;
            else TEL = false;

            String dept="urg";
            Char chambre = 'C';

            if (comboBox_iddept.SelectedIndex != -1) {
                int selection = comboBox_iddept.SelectedIndex;
                switch (selection)
                {
                    case 0: dept = "ped";
                        //MessageBox.Show("département sélectionné : "+ dept);
                        break;
                    case 1: dept = "urg";
                        //MessageBox.Show("département sélectionné : " + dept);
                        break;
                    case 2: dept = "intensif";
                        //MessageBox.Show("département sélectionné : " + dept);
                        break;
                    default:
                        MessageBox.Show("Sélectionnez un département");
                        break;
                }

                if (comboBox_type_chambre.SelectedIndex != -1)
                {
                    int selection2 = comboBox_type_chambre.SelectedIndex;
                    switch (selection2)
                    {
                        case 0:
                            chambre = 'A';
                            //MessageBox.Show("Type chambre sélectionné : " + chambre);
                            break;
                        case 1:
                            chambre = 'B';
                            //MessageBox.Show("Type chambre sélectionné : " + chambre);
                            break;
                        case 2:
                            chambre = 'C';
                            //MessageBox.Show("Type chambre sélectionné : " + chambre);
                            break;
                        default:
                            break;
                    }
                }
            //Valide l'existence du patient avec le NAs entrée
            var query =
            from c in Acceuil.maBDD.Patients where c.NAS== tb_nas.Text
            select new { c.Nom, c.Prenom, c.NAS, c.Adresse_civique, c.App, c.Ville, c.Province, c.Code_postal, c.Telephone, c.Date_naissance, c.IDAssurance };

            //Valide l'existence du Medecin avec l'id entrée
            var query2 =
            from c in Acceuil.maBDD.Medecins where c.IDMedecin == tb_idMED.Text
            select new { c.nom, c.prenom, c.IDMedecin };

            //Si les 2 sont valides ont peut continuer
            if (query.Count() == 1 && query2.Count() == 1)
            {

                //Trouve le premier lit libre qui respecte la condition
                String chambre_string=chambre.ToString();
                Lit un_lit = (from c in Acceuil.maBDD.Lits
                              where c.occupee == false
                              where c.IDType == chambre_string
                              where c.IDDepartement == dept
                              select c ).FirstOrDefault();

                //si lit réponds au critère on poursuit
                if (un_lit != null)
                {

                    try
                    {

                        un_lit.occupee = true;//par défaut

                        ///AJOUT DE L'ADMISSION
                        Admission une_admission = new Admission();


                        try
                        {
                            //Le id s'incrémente automatiquement par l'ajout
                            une_admission.Chirurchie_programmee = chirurgie_prog;
                            une_admission.date_admission = DateTime.Parse(date_admin);
                            une_admission.date_chirurgie = DateTime.Parse(date_chirurgie);
                            une_admission.date_congee = null;//par défaut
                            une_admission.telephone = TEL;
                            une_admission.televiseur = TV;
                            une_admission.NAS = tb_nas.Text;
                            une_admission.Numero_lit = un_lit.Numero_lit;////////////le lit quon vient de "trouver"
                            une_admission.IDMedecin = tb_idMED.Text;


                            Acceuil.maBDD.Admissions.Add(une_admission);
                            Acceuil.maBDD.SaveChanges();
                           // MessageBox.Show("Admission du patient ajouté avec succès!");
                            MessageBox.Show("Admission du patient ajouté avec succès!", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);



                            }
                            catch (Exception ex)
                        {
                           // MessageBox.Show(ex.Message);
                                MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                        


                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.Message);
                            MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                else {
                        MessageBox.Show("Aucun lit de disponible répondant à ces critères", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                        //MessageBox.Show("Aucun lit de disponible répondant à ces critères");
                }
                


            }
            else {

                if (query.Count() != 1) {
                    //MessageBox.Show("Erreur au niveau du NAS du patient: Patient inconnue");
                        MessageBox.Show("Erreur au niveau du NAS du patient: Patient inconnue", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                if (query2.Count() != 1)
                {
                        MessageBox.Show("Erreur au niveau de l'id du médecin: Médecin inconnue", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);

                        //MessageBox.Show("Erreur au niveau de l'id du médecin: Médecin inconnue");
                }



            }

            }


        }

        private void btn_retour_Click(object sender, RoutedEventArgs e)
        {
            Preposee fenetre_preposee = new Preposee();
            fenetre_preposee.Show();
            this.Close();
        }
    }
}
