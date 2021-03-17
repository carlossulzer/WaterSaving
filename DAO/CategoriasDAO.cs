using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterSaving
{
    class CategoriasDAO
    {
        public void CarregarCategorias(ref ComboBox comboboxPreenchido)
        {
            CarregarDropDown dropCarregar = new CarregarDropDown();
            dropCarregar.PopularEnumeracao(ref comboboxPreenchido, typeof(ECategoria), "<SELECIONE A CATEGORIA>", "-1");
           
        }
    }
}
