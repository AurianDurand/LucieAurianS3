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
using Metier_Aurian;

namespace IHM_Aurian
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Morpion morpion = new Morpion();
        public MainWindow()
        {
            InitializeComponent();
        }

        //méthode appelée lorsque l'on clique sur le bouton "Joueur"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //si les joueurs ont pu être créés correctement
            if (this.morpion.saisieNomsJoueurs(TBoxNom1.Text, TBoxNom2.Text))
            {
                Button button = (Button)sender;
                button.Content = "Recommencer";
                resetPlateauJeu();
                MessageBox.Show("La partie peut commencer !");
            }

            //sinon on demande à l'utilisateur d'entrer
            else
            {
                MessageBox.Show("Les noms des joueurs sont incorrects, veuillez recommencer");
            }
        }

        private void genererHistorique(int x, int y)
        {
            int numTour = morpion.Tour;
            x++; //afin d'avoir un x entre 1 et 3 plutôt que entre 0 et 2
            y++; //afin d'avoir un y entre 1 et 3 plutôt que entre 0 et 2

            string xString = "";
            switch (x)
            {
                case 1: xString = "A";
                    break;
                case 2: xString = "B";
                    break;
                case 3: xString = "C";
                    break;
            }

            //ensuite affiche l'historique dans le label correspondant au numéro du tour
            switch (numTour)
            {
                case 1:
                    histo1.Content = "" + morpion.getNomJoueurQuiClique() + " : " + xString + "," + y;
                    break;
                case 2:
                    histo2.Content = "" + morpion.getNomJoueurQuiClique() + " : " + xString + "," + y;
                    break;
                case 3:
                    histo3.Content = "" + morpion.getNomJoueurQuiClique() + " : " + xString + "," + y;
                    break;
                case 4:
                    histo4.Content = "" + morpion.getNomJoueurQuiClique() + " : " + xString + "," + y;
                    break;
                case 5:
                    histo5.Content = "" + morpion.getNomJoueurQuiClique() + " : " + xString + "," + y;
                    break;
                case 6:
                    histo6.Content = "" + morpion.getNomJoueurQuiClique() + " : " + xString + "," + y;
                    break;
                case 7:
                    histo7.Content = "" + morpion.getNomJoueurQuiClique() + " : " + xString + "," + y;
                    break;
                case 8:
                    histo8.Content = "" + morpion.getNomJoueurQuiClique() + " : " + xString + "," + y;
                    break;
                case 9:
                    histo9.Content = "" + morpion.getNomJoueurQuiClique() + " : " + xString + "," + y;
                    break;
            }
        }

        //cette méthode demande à la classe morpion du code métier ce qu'elle doit faire
        private void imageGeneralFunction(Image image, int x, int y)
        {
            //si le joueur courant n'est pas nul, la partie est en cours et donc on demande au metier quoi faire
            if(morpion.isJoueurCourantNotNull())
            {       
                int numJoueur = morpion.cocherCase(x, y);

                //si le metier retourne 1, alors on dessine une croix
                if (numJoueur == 1)
                {
                    image.Source = new BitmapImage(new Uri(@"/Assets/croix.jpg", UriKind.Relative));
                    //ensuite on génère l'historique
                    genererHistorique(x, y);
                }

                //si le metier retourne 2, alors on dessine un rond
                else if(numJoueur == 2)
                {
                    image.Source = new BitmapImage(new Uri(@"/Assets/rond.jpg", UriKind.Relative));
                    //ensuite on génère l'historique
                    genererHistorique(x, y);
                }
                //si le metier retourne autre chose que 1 ou 2, alors on ne fait rien   

                //ensuite, il faut vérifier si l'un des joueurs gagne, pour ce faire on va à nouveau demandé au métier d'agir

            }
        }

        //cette méthode a pour but de réinitialiser la partie afin de pouvoir en faire une autre
        //cette fonctionnalité n'est pas fonctionnelle 
        private void resetPlateauJeu()
        {
            Image0.Source=Image1.Source=Image2.Source=Image3.Source=Image4.Source=Image5.Source=Image6.Source=Image7.Source=Image8.Source= new BitmapImage(new Uri(@"/Assets/carreBlanc.png", UriKind.Relative));
        }

        //ces méthodes sont appellées lorsque l'on clique sur une image puis appellent imageGeneralFunction en transmétant leur coordonnées et elles mêmes
        private void Image0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            imageGeneralFunction(image, 0, 0);
        }
        private void Image1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            imageGeneralFunction(image, 1, 0);
        }

        private void Image2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            imageGeneralFunction(image, 2, 0);
        }

        private void Image3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            imageGeneralFunction(image, 0, 1);
        }

        private void Image4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            imageGeneralFunction(image, 1, 1);
        }
        private void Image5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            imageGeneralFunction(image, 2, 1);
        }
        private void Image6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            imageGeneralFunction(image, 0, 2);
        }
        private void Image7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            imageGeneralFunction(image, 1, 2);
        }
        private void Image8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image)sender;
            imageGeneralFunction(image, 2, 2);
        }
    }
}   
