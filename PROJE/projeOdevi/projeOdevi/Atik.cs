using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    public class Atik :IAtik
    {
        public int Hacim { get; set; }
        public string Cins{ get; set; }
        public string Ad { get; set; }

        public Image Image => throw new NotImplementedException();

        public Atik(string cins,string ad,int hacim)
        {
            Cins = cins;
            Ad = ad;
            Hacim = hacim;
        }
        public override string ToString()
        {
            return $"{Ad.ToUpper()} ({Hacim})";
        }
    }
}
