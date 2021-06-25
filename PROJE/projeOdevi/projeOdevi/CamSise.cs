using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    class CamSise : Atik, IAtik
    {
        public new int Hacim => 600;
        public new Image Image => Image.FromFile("camsise.png");

        public CamSise():base("Cam","camsise",600)
        {
                
        }
    }
}
