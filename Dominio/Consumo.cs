using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterSaving
{
    public class Consumo
    {
        public int NumPessoas { get; set; }
        
        public bool LavagemdeCarro { get; set; }
        public int NumCarros { get; set; }
        public int LavagemPorMes { get; set; }

        public bool RegadeJardim { get; set; }
        public int ReganoMes { get; set; }
        public double RegaM2 { get; set; }
        public bool RegaNaoSei { get; set; }

        public bool LavagemAreaComum { get; set; }
        public int LavagemAreaMes { get; set; }
        public double LavagemAreaM2 { get; set; }
        public bool LavagemAreaNaoSei { get; set; }

        public bool BaciaSanitaria { get; set; }
        public bool Bacia6L { get; set; }
        public bool Bacia3ou6L { get; set; }

        public double TotalM3Mes { get; set; }
    }
}
