﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOdevi
{
    class Salatalik : Atik, IAtik
    {
        public new int Hacim => 120;
        public new Image Image => Image.FromFile("salatalik.png");

        public Salatalik() : base("Organik","salatalik",120)
        {
           
        }
    }
}
