using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterSaving
{
    class CategoriasCTL
    {
        public void CarregarCategorias(ref ComboBox comboboxPreenchido)
        {
            CategoriasDAO categoriasDAO = new CategoriasDAO();
            categoriasDAO.CarregarCategorias(ref comboboxPreenchido);
        }
    }
}
