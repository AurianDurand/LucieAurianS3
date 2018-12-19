using System;
using System.Collections.Generic;
using System.Text;

namespace Metier_Aurian
{
    public class Joueur
    {
        private List<Case> casesCoche;
        private string nom;
        public string Nom { get => nom; set => nom = value; }

        public Joueur(string nom)
        {
            this.Nom = nom; //attribut au joueur le nom correcpondant lors de sa création
        }

        
    }
}
