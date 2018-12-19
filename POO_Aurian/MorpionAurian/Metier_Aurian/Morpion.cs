using System;
using System.Collections.Generic;
using System.Text;

namespace Metier_Aurian
{
    public class Morpion
    {
        private List<Case> cases;
        private Joueur joueurCourant = null;
        private Joueur joueur1;
        private Joueur joueur2;
        private int tour = 0;
        public Joueur Joueur1 { get => joueur1; set => joueur1 = value; }
        public Joueur Joueur2 { get => joueur2; set => joueur2 = value; }
        public int Tour { get => tour; }

        //retourne si le joueur courant n'est pas nul
        //si vrai, la partie est donc en cours
        //si faux, la partie n'a pas encore commencée 
        public Boolean isJoueurCourantNotNull()
        {
            Boolean b = false;
            if (this.joueurCourant != null) { b = true; }
            return b;
        }

        //retourne le nom du joueur qui a cliqué sur la case
        public string getNomJoueurQuiClique()
        {
            if(this.joueurCourant == joueur1)
            {
                return Joueur2.Nom; //si le joueur courant est le 1 lors de l'appel de cette méthode, alors c'est le joueur 2 qui avait cliqué 
            }
            else
            {
                return Joueur1.Nom; //si le joueur courant est le 2 lors de l'appel de cette méthode, alors c'est le joueur 1 qui avait cliqué 
            }
        }

        public Morpion()
        {
            //ici le jeu crée toutes les cases pour la partie
            this.cases = new List<Case>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.cases.Add(new Case(i, j));
                }
            }
        }

        //retourne true si les joueurs ont bien pu être créés, sinon retourne false
        public Boolean saisieNomsJoueurs(string nom1, string nom2)
        {
            //ici le jeu vérifie que les noms entrés pour les joueurs respectent bien les conditions de création 
            if(nom1!=nom2 && nom1!="" && nom2!="" && nom1!="IA" && nom1 != "ia")
            {
                //si les conditions sont respectées, alors on crée les joueurs 
                Joueur1 = new Joueur(nom1);
                Joueur2 = new Joueur(nom2);
                this.joueurCourant = Joueur1; //et on attribut le joueur1 au joueur courant 
                return true;
            }
            else { return false; }
        }

        //cette méthode a poru but re récupérer les coordonnées de la case sur laquelle le joueur clique
        //suite à cela, la méthode va vérifier si la case a déjà été cliquée et retourner une instructions à l'IHM
        //la méthode retourne 1 si c'est le joueur1 qui a coché la case, 2 si c'est le joueur2, sinon 0
        public int cocherCase(int x, int y)
        {
            //trouve la case correspondant aux coordonées entrées
            int toreturn = 0;
            Case caseClicked=null;
            foreach(Case c in this.cases)
            {
                if(c.X == x && c.Y == y)
                {
                    caseClicked = c;
                }
            }

            //si la case n'a pas déjà été cochée
            if(caseClicked.CochePar==null)
            {
                //si c'est le tour du joueur 1
                if(this.joueurCourant==Joueur1)
                {
                    toreturn = 1;
                    caseClicked.CochePar = this.joueurCourant;
                    this.joueurCourant = Joueur2;
                }

                //sinon c'est le tour du joueur 2
                else
                {
                    toreturn = 2;
                    caseClicked.CochePar = this.joueurCourant;
                    this.joueurCourant = Joueur1;
                }
                this.tour++;
            }

            //sinon la case a été cochée
            else
            {
                toreturn = 0;
            }
            return toreturn;
        }
        public int gagner()
        {
            Joueur j;
            //vérifie horizontallement
            if (this.cases[0].CochePar == this.cases[1].CochePar && this.cases[0].CochePar == this.cases[2].CochePar)
            {
                j = this.cases[0].CochePar;
            }
            else if(this.cases[3].CochePar == this.cases[4].CochePar && this.cases[3].CochePar == this.cases[5].CochePar)
            {
                j = this.cases[3].CochePar;
            }
            else if (this.cases[6].CochePar == this.cases[7].CochePar && this.cases[6].CochePar == this.cases[8].CochePar)
            {
                j = this.cases[6].CochePar;
            }

            //vérifie vetivalement
            if (this.cases[0].CochePar == this.cases[3].CochePar && this.cases[0].CochePar == this.cases[6].CochePar)
            {
                j = this.cases[0].CochePar;
            }
            else if (this.cases[1].CochePar == this.cases[4].CochePar && this.cases[1].CochePar == this.cases[7].CochePar)
            {
                j = this.cases[1].CochePar;
            }
            else if (this.cases[2].CochePar == this.cases[5].CochePar && this.cases[2].CochePar == this.cases[8].CochePar)
            {
                j = this.cases[2].CochePar;
            }

            //vérifie les diagonales
            if (this.cases[0].CochePar == this.cases[4].CochePar && this.cases[0].CochePar == this.cases[8].CochePar)
            {
                j = this.cases[0].CochePar;
            }
            else if (this.cases[2].CochePar == this.cases[4].CochePar && this.cases[2].CochePar == this.cases[6].CochePar)
            {
                j = this.cases[2].CochePar;
            }

            if(j == this.joueur1)
            {
                return 1;
            }
            else if(j == this.Joueur2)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
