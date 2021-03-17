using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WaterSaving
{
    public enum ECategoria
    {
        [Description("RESIDENCIAL")]
        Residencial = 1,
        [Description("COMERCIAL")]
        Comercial = 2,
        [Description("INDUSTRIAL")]
        Industrial = 3,
        [Description("PÚBLICA")]
        Publica = 4


    }

}
