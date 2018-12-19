using System;
using System.Collections.Generic;
using System.Text;

namespace Metier_Aurian
{
    public class Case
    {
        private int x;
        private int y;
        private Joueur cochePar = null;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Joueur CochePar { get => cochePar; set => cochePar = value; }

        public Case(int x, int y)
        {
            //attribut à la  case ses coordinnées lors de sa création 
            this.X = x;
            this.y = y;
        } 
    }
}
