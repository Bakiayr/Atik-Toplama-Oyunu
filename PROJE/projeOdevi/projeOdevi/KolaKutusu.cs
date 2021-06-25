using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    class KolaKutusu : Atik, IAtik
    {
        public new int Hacim => 350;
        public new Image Image => Image.FromFile("kola.png");

        public KolaKutusu():base("Metal","kola",350)
        {
                
        }
    }
}
