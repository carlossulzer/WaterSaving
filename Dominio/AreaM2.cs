using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterSaving
{
    class AreaM2
    {
        public AreaM2() { }

        public AreaM2(string descricao, string tipo, int inclinacao, double m2)
        {
            Descricao = descricao;
            M2 = m2;
        }


        public string Descricao { get; set; }
        public double M2 { get; set; }
    }
}
