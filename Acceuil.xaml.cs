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
    /// Logique d'interaction pour Acceuil.xaml
    /// </summary>
    public partial class Acceuil : Window
    {

        public static BDD_northernEntities maBDD;



        public Acceuil()
        {
            InitializeComponent();
            maBDD = new BDD_northernEntities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            
        }



        private void btn_connexion_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(tb_nom.Text) && !String.IsNullOrEmpty(tb_mp.Password))
            {
                if (tb_nom.Text == tb_mp.Password)
                {


                    String entree = tb_nom.Text;

                    switch (entree)
                    {
                        case "admin":
                            //MessageBox.Show("Case 1: admin");
                            //ouverture de la fenetre admin
                            Admin fenetre_admin = new Admin();
                            fenetre_admin.Show();
                            this.Close();

                            break;
                        case "prep":
                            //MessageBox.Show("Case 2: prep");
                            //ouverture de la fenetre préposée
                            Preposee fenetre_prep = new Preposee();
                            fenetre_prep.Show();
                            this.Close();
                            break;
                        case "med":
                            //MessageBox.Show("Case 3: med");
                            //ouverture de la fenetre médecin
                            IMedecin fenetre_med = new IMedecin();
                            fenetre_med.Show();
                            this.Close();
                            break;

                    }

                    





                }
                else {
                    MessageBox.Show("erreur: les entrées ne conrrespondent pas ensembles");
                }
            }
            else
            {
                MessageBox.Show("(Champs vides) Remplisser les 2 champs");
            }



            //vidage des entrée
            tb_nom.Text = String.Empty;
            tb_mp.Password = String.Empty;
        }

      
    }
}
