using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    class Gazete : Atik, IAtik
    {
        public new int Hacim => 250;
        public new Image Image => Image.FromFile("gazete.png");
        public Gazete():base("Kagit","gazete",250)
        {
                
        }
    }
}
