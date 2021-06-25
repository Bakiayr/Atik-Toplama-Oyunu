using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    class SalcaKutusu : Atik, IAtik
    {
        public new int Hacim => 550;
        public new Image Image => Image.FromFile("salca.png");

        public SalcaKutusu():base("Metal","salca",550)
        {

        }
    }
}
