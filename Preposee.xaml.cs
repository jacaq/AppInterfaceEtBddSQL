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
    /// Logique d'interaction pour Preposee.xaml
    /// </summary>
    public partial class Preposee : Window
    {
        public Preposee()
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
            
            //datepicker
            datePicker_nai_patient.SelectedDate = DateTime.Now;
        }

        private void btn_ajouter_patient_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_adresse_patient.Text) || !String.IsNullOrEmpty(tb_nom_patient.Text) || !String.IsNullOrEmpty(tb_prenom_patient.Text))
            {


                String name="", surname="", the_nas="", adress="", app="", ville="", province = "", code_postal = "", tel = "", dateNai = "";


                surname = tb_nom_patient.Text;
                name = tb_prenom_patient.Text;
                the_nas = tb_nas_patient.Text;
                adress = tb_adresse_patient.Text;
                app = tb_app_patient.Text;
                ville = tb_ville_patient.Text;
                province = tb_province_patient.Text;
                code_postal = tb_postal_patient.Text;
                tel = tb_tel_patient.Text;
                dateNai = datePicker_nai_patient.SelectedDate.ToString();//.ToString("MM-dd-yyyy");


                //Medecin un_med = new Medecin();
                Patient un_patient = new Patient();


                try
                {
                    un_patient.NAS = the_nas;
                    un_patient.Nom = surname;
                    un_patient.Prenom = name;
                    un_patient.Date_naissance = DateTime.Parse(dateNai);//???
                    un_patient.Code_postal = code_postal;
                    un_patient.Adresse_civique = adress;
                    un_patient.App = app;
                    un_patient.Province = province;
                    un_patient.Ville = ville;
                    un_patient.Telephone = tel;
                    un_patient.Assurance = null;

                    String comp_assurance, id_assurance;
                    if (!String.IsNullOrEmpty(tb_ID_ass.Text)) {

                        id_assurance = tb_ID_ass.Text;

                        if (!String.IsNullOrEmpty(tb_Com_ass.Text))
                        {
                            comp_assurance = tb_Com_ass.Text;
                            un_patient.IDAssurance = id_assurance;
                            //Création objet de l'assurance
                            Assurance new_assurance = new Assurance();
                            new_assurance.IDAssurance = id_assurance;
                            new_assurance.nom_compagnie = comp_assurance;
                            Acceuil.maBDD.Assurances.Add(new_assurance);
                            Acceuil.maBDD.SaveChanges();
                        }
                        else {
                            MessageBox.Show("Entrez le nom de la compagnie d'assurance");
                        }
                    }



                    Acceuil.maBDD.Patients.Add(un_patient);
                    Acceuil.maBDD.SaveChanges();
                    MessageBox.Show("Patient ajouté avec succès!");



                }
                catch (Exception ex)
                {



                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btn_admission_Click(object sender, RoutedEventArgs e)
        {
            IAdmission fenetre_admission = new IAdmission();
            //ouverture de la page admission
            fenetre_admission.Show();
            this.Close();
        }

        private void btn_rechercher_patient_Click(object sender, RoutedEventArgs e)
        {
            IRecherchePatient fenetre_recherchePatient = new IRecherchePatient();
            fenetre_recherchePatient.Show();
            this.Close();
        }

        private void btn_reset_patient_Click(object sender, RoutedEventArgs e)
        {
            //Vide les champs 
            tb_nom_patient.Text = String.Empty;
            tb_prenom_patient.Text = String.Empty;
            tb_nas_patient.Text = String.Empty;
            tb_adresse_patient.Text = String.Empty;
            tb_app_patient.Text = String.Empty;
            tb_ville_patient.Text = String.Empty;
            tb_province_patient.Text = String.Empty;
            tb_postal_patient.Text = String.Empty;
            tb_tel_patient.Text = String.Empty;
            tb_Com_ass.Text= String.Empty;
            tb_ID_ass.Text= String.Empty;
            datePicker_nai_patient.SelectedDate = DateTime.Now;

        }
    }
}
