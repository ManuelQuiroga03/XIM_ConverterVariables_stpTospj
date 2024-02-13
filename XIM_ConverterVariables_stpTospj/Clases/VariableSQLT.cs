using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIM_ConverterVariables_stpTospj.Clases
{
    public class VariableSQLT<T>
    {
        public string Nombre { get; set; }
        public T Valor { get; set; }

        public VariableSQLT(string nombre, T valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}
