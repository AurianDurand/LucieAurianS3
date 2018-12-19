using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD04
{
    public class Gaufre : IDessert
    {
        public string Libelle { get => "Gaufre"; }
        public float Prix { get => 3; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Libelle + "(" + Prix + ")";
        }
    }
}
