using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    class Bardak : Atik, IAtik
    {
        public new int Hacim => 250;
        public new Image Image => Image.FromFile("bardak.png");

        public Bardak() : base("Cam", "bardak",250)
        {

        }
    }
}
