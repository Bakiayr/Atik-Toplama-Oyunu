using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    public class AtikKutusu : IAtikKutusu
    {
        public int BosaltmaPuani { get; set; }
        public double Kapasite { get; set; }
        public double DoluHacim { get; set; }
        public double DolulukOrani => (DoluHacim /Kapasite) * 100;

        public AtikKutusu(int puan,int kapasite)
        {
            BosaltmaPuani = puan;
            Kapasite = kapasite;
        }
        
        public bool Ekle(Atik atik)
        {
            if (atik.Hacim + DoluHacim <= Kapasite)
            {
                return true;
            }
            else
                return false;
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            else
                return false;
        }
    }
}
