using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    class Dergi : Atik, IAtik
    {
        public Dergi():base("Kagit","dergi",200)
        {
              
        }

        public new int Hacim => 200;

        public new Image Image => Image.FromFile("dergi.png");
    }
}
