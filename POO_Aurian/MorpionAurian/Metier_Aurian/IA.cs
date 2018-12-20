using System;
using System.Collections.Generic;
using System.Text;

namespace Metier_Aurian
{
    public class IA : Joueur
    {
        private Morpion morpion;

        private int ligne1 = 0;
        private int ligne2 = 0;
        private int ligne3 = 0;
        private int colonne1 = 0;
        private int colonne2 = 0;
        private int colonne3 = 0;
        private int dia_HG_BD = 0;
        private int dia_HD_BG = 0;

        private int IAligne1 = 0;
        private int IAligne2 = 0;
        private int IAligne3 = 0;
        private int IAcolonne1 = 0;
        private int IAcolonne2 = 0;
        private int IAcolonne3 = 0;
        private int IAdia_HG_BD = 0;
        private int IAdia_HD_BG = 0;

        public IA(string nom, Morpion morpion) : base(nom)
        {
            this.morpion = morpion;
        }

        /// <summary>
        /// centre de décision de l'IA simple
        /// </summary>
        /// <returns></returns>
        public StructCoo decide()
        {
            StructCoo coo = new StructCoo();
            List<Case> cases = this.morpion.Cases;
            foreach (Case c in cases)
            {
                if(c.CochePar == null)
                {
                    coo.x = c.X;
                    coo.y = c.Y;
                }
            }
            return coo;
        }

        /// <summary>
        /// centre de décision de l'IA avancée
        /// </summary>
        /// <returns></returns>
        public StructCoo strongIaDecide()
        {
            StructCoo coo = new StructCoo();

            verifCasesCochesParJ1(); //on vérifi la position des croix du joueur 1

            verifCasesCochesParIA(); //on vérifi la position des ronds de l'IA

            if (this.ligne1>=2)
            {
                if(this.IAligne1==0)
                {
                    foreach (Case c in this.morpion.Cases)
                    {
                        if (c.X == 0 && c.Y == 0)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 1 && c.Y == 0)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 2 && c.Y == 0)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                    }
                }
            }
            else if(this.ligne2 >= 2)
            {
                if (this.IAligne2 == 0)
                {
                    foreach (Case c in this.morpion.Cases)
                    {
                        if (c.X == 0 && c.Y == 1)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 1 && c.Y == 1)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 2 && c.Y == 1)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                    }
                }
            }
            else if (this.ligne3 >= 2)
            {
                if (this.IAligne3 == 0)
                {
                    foreach (Case c in this.morpion.Cases)
                    {
                        if (c.X == 0 && c.Y == 2)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 1 && c.Y == 2)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 2 && c.Y == 2)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                    }
                }
            }
            else if (this.colonne1 >= 2)
            {
                if (this.IAcolonne1 == 0)
                {
                    foreach (Case c in this.morpion.Cases)
                    {
                        if (c.X == 0 && c.Y == 0)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 0 && c.Y == 1)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 0 && c.Y == 2)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                    }
                }
            }
            else if (this.colonne2 >= 2)
            {
                if (this.IAcolonne2 == 0)
                {
                    foreach (Case c in this.morpion.Cases)
                    {
                        if (c.X == 1 && c.Y == 0)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 1 && c.Y == 1)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 1 && c.Y == 2)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                    }
                }
            }
            else if (this.colonne3 >= 2)
            {
                if (this.IAcolonne3 == 0)
                {
                    foreach (Case c in this.morpion.Cases)
                    {
                        if (c.X == 2 && c.Y == 0)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 2 && c.Y == 1)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 2 && c.Y == 2)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                    }
                }
            }
            else if (this.dia_HG_BD >= 2)
            {
                if (this.IAdia_HG_BD == 0)
                {
                    foreach (Case c in this.morpion.Cases)
                    {
                        if(c.X==0 && c.Y==0)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 1 && c.Y == 1)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 2 && c.Y == 2)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                    }
                }
            }
            else if (this.dia_HD_BG >= 2)
            {
                if (this.IAdia_HD_BG == 0)
                {
                    foreach (Case c in this.morpion.Cases)
                    {
                        if (c.X == 2 && c.Y == 0)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 1 && c.Y == 1)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                        else if (c.X == 0 && c.Y == 2)
                        {
                            coo.x = c.X;
                            coo.y = c.Y;
                        }
                    }
                }
            }
            else
            {
                foreach (Case c in this.morpion.Cases)
                {
                    if (c.CochePar == null)
                    {
                        coo.x = c.X;
                        coo.y = c.Y;
                    }
                }
            }

            StructCoo coo2 = new StructCoo();
            List<Case> cases = this.morpion.Cases;
            foreach (Case c in cases)
            {
                if (c.CochePar == null)
                {
                    coo2.x = c.X;
                    coo2.y = c.Y;
                }
            }

            foreach (Case c2 in this.morpion.Cases)
            {
                if (c2.CochePar != null)
                {
                    coo = coo2;
                }
            }

                return coo;
        }

        /// <summary>
        /// cette méthone vérifie les positions des croix (joueur1) afin de pouvoir le contrer
        /// </summary>
        public void verifCasesCochesParJ1()
        {
            List<Case> cases = this.morpion.Cases;
            foreach (Case c in cases)
            {
                if(c.CochePar==this.morpion.Joueur1)
                {
                    if (c.X == 0 && c.Y == 0)
                    {
                        this.ligne1++;
                        this.colonne1++;
                        this.dia_HG_BD++;
                    }
                    else if (c.X == 1 && c.Y == 0)
                    {
                        this.ligne1++;
                        this.colonne2++;
                    }
                    else if (c.X == 2 && c.Y == 0)
                    {
                        this.ligne1++;
                        this.colonne3++;
                        this.dia_HD_BG++;
                    }
                    else if (c.X == 0 && c.Y == 1)
                    {
                        this.ligne2++;
                        this.colonne1++;
                    }
                    else if (c.X == 1 && c.Y == 1)
                    {
                        this.ligne2++;
                        this.colonne2++;
                        this.dia_HG_BD++;
                        this.dia_HD_BG++;
                    }
                    else if (c.X == 2 && c.Y == 1)
                    {
                        this.ligne2++;
                        this.colonne3++;
                    }
                    else if (c.X == 0 && c.Y == 2)
                    {
                        this.ligne3++;
                        this.colonne1++;
                        this.dia_HD_BG++;
                    }
                    else if (c.X == 1 && c.Y == 2)
                    {
                        this.ligne3++;
                        this.colonne2++;
                    }
                    else if (c.X == 2 && c.Y == 2)
                    {
                        this.ligne3++;
                        this.colonne2++;
                        this.dia_HG_BD++;
                    }
                }                
            }
        }

        /// <summary>
        /// cette méthone vérifie les positions des ronds (IA) afin de pouvoir choiri ou jouer
        /// </summary>
        public void verifCasesCochesParIA()
        {
            List<Case> cases = this.morpion.Cases;
            foreach (Case c in cases)
            {
                if (c.CochePar == this.morpion.Joueur2)
                {
                    if (c.X == 0 && c.Y == 0)
                    {
                        this.IAligne1++;
                        this.IAcolonne1++;
                        this.IAdia_HG_BD++;
                    }
                    else if (c.X == 1 && c.Y == 0)
                    {
                        this.IAligne1++;
                        this.IAcolonne2++;
                    }
                    else if (c.X == 2 && c.Y == 0)
                    {
                        this.IAligne1++;
                        this.IAcolonne3++;
                        this.IAdia_HD_BG++;
                    }
                    else if (c.X == 0 && c.Y == 1)
                    {
                        this.IAligne2++;
                        this.IAcolonne1++;
                    }
                    else if (c.X == 1 && c.Y == 1)
                    {
                        this.IAligne2++;
                        this.IAcolonne2++;
                        this.IAdia_HG_BD++;
                        this.IAdia_HD_BG++;
                    }
                    else if (c.X == 2 && c.Y == 1)
                    {
                        this.IAligne2++;
                        this.IAcolonne3++;
                    }
                    else if (c.X == 0 && c.Y == 2)
                    {
                        this.IAligne3++;
                        this.IAcolonne1++;
                        this.IAdia_HD_BG++;
                    }
                    else if (c.X == 1 && c.Y == 2)
                    {
                        this.IAligne3++;
                        this.IAcolonne2++;
                    }
                    else if (c.X == 2 && c.Y == 2)
                    {
                        this.IAligne3++;
                        this.IAcolonne2++;
                        this.IAdia_HG_BD++;
                    }
                }
            }
        }
    }
}
