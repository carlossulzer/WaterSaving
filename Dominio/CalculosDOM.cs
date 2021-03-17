using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterSaving
{
    class CalculosDOM
    {
        public int CodProjeto { get; set; }
        public int CodMunicipio { get; set; }
        public int CodMedicao { get; set; }
        public double CustoM3Agua { get; set; }
        public double AreaCaptacao { get; set; }
        public double DemandaMensal { get; set; }
        public double CotacaoDollar { get; set; }
        public double VolReservatorio { get; set; }
        public double EconomiaAnual { get; set; }
        public double DespesaAnual { get; set; }
        public double TaxaAtratividade { get; set; }
        public int AnosRetorno { get; set; }
    }
}
