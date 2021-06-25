using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    class Domates : Atik, IAtik
    {
        public new int Hacim => 150;
        public new Image Image => Image.FromFile("domates.png");

        public Domates():base("Organik","domates",150)
        {
                
        }
    }
}
