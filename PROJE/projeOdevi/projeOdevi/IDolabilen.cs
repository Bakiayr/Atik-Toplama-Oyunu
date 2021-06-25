using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    public interface IDolabilen
    {
        double Kapasite { get; }
        double DoluHacim { get; set; }
        double DolulukOrani { get; }
    }
}