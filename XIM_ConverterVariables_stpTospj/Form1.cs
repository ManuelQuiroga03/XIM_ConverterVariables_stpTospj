using System.Text;
using System.Text.RegularExpressions;
using XIM_ConverterVariables_stpTospj.Clases;

namespace XIM_ConverterVariables_stpTospj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_Convert.Click += btn_Convert_Click!;
        }

        private string tipoConversion = "A";

        private string EliminarTipoDato(string input)
        {
            // Expresión regular para buscar y eliminar el tipo de dato
            //string pattern = @"(?<tipoDato>\b(?:BIGINT|VARCHAR|INT|DATETIME|TYNINT|CHAR|BIT|NUMERIC)\b)\((?<valor>.+)\)";
            string pattern = @"(?<tipoDato>\b(?:BIGINT|VARCHAR|INT|DATETIME|TYNINT|CHAR|BIT|NUMERIC)\b)(?:\((?<precision>\d+)(?:,(?<scale>\d+))?\))?";

            // Utilizar regex para reemplazar el tipo de dato con una coma
            return System.Text.RegularExpressions.Regex.Replace(input, pattern, string.Empty, RegexOptions.IgnoreCase).TrimStart().TrimEnd(',');
        }

        private string ObtenerTipoDatoConLongitud(string input)
        {
            string pattern = @"\b(?:\w+)(?:\(\s*\d+\s*,\s*\d+\s*\))?\b";
            //string pattern = @"(@\w+)\s+(\w+)(?:\s*\(\s*(\d+)\s*,\s*(\d+)\s*\))?\s*=\s*(.+)";
            Match match = Regex.Match(input, pattern);
            return match.Success ? match.Value.Trim() : string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            // Obtén el contenido del TextBox txt_Promp
            string entrada = txt_Promp.Text;

            // Divide las líneas de entrada
            string[] lineas = Regex.Split(entrada, @",(?![^(]*\))")
                     .Select(l => l.Trim())
                     .ToArray();



            // Objeto StringBuilder para construir el resultado
            StringBuilder resultado = new StringBuilder();

            if (tipoConversion == "A")
            {
                // Itera sobre cada línea y realiza la conversión
                foreach (var linea in lineas)
                {
                    // Dividir cada línea en palabras ignorando espacios alrededor del '='
                    string[] partes = linea.Trim().Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                    // Verificar si hay suficientes partes para la conversión
                    if (partes.Length == 2)
                    {
                        // Obtener el nombre de la variable
                        string nombreVariable = partes[0].TrimStart('@').Trim();

                        // Obtener la parte derecha del '='
                        string parteDerecha = partes[1].TrimEnd(',');

                        // Utilizar expresión regular para encontrar y eliminar el tipo de dato
                        nombreVariable = EliminarTipoDato(nombreVariable);
                        parteDerecha = EliminarTipoDato(parteDerecha);

                        // Crear la cadena de resultado con la sintaxis deseada
                        resultado.AppendLine($"@{nombreVariable} = ISNULL({nombreVariable}, {parteDerecha}),");
                    }
                }
            }else if (tipoConversion == "B")
            {
                // Itera sobre cada línea y realiza la conversión
                foreach (var linea in lineas)
                {
                    // Dividir cada línea en palabras ignorando espacios alrededor del '='
                    string[] partes = linea.Trim().Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                    // Verificar si hay suficientes partes para la conversión
                    if(partes.Length == 1)
                    {
                        string nombreVariable = partes[0].TrimStart('@').Trim();
                        string tipoDato = ObtenerTipoDatoConLongitud(partes[0]);

                        // Crear la cadena de resultado con la sintaxis deseada
                        resultado.AppendLine($"{nombreVariable} '$.{tipoDato}',");
                    }
                    else if (partes.Length == 2)
                    {
                        // Obtener el nombre de la variable
                        string nombreVariable = partes[0].TrimStart('@').Trim();

                        // Obtener la parte derecha del '=' y eliminar el tipo de dato
                        string parteDerecha = EliminarTipoDato(partes[1].TrimEnd(',')).Trim();

                        // Obtener el tipo de dato con longitud si es que tiene
                        string tipoDato = ObtenerTipoDatoConLongitud(partes[0]);

                        // Crear la cadena de resultado con la sintaxis deseada
                        resultado.AppendLine($"{nombreVariable} '$.{tipoDato}',");
                    }
                }
            }

            // Mostrar el resultado en el TextBox txt_Result
            txt_Result.Text = resultado.ToString();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_Promp.Clear();
            txt_Result.Clear();
        }

        private void rb_TipoA_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_TipoA.Checked)
            {
                tipoConversion = "A";
            }
        }

        private void rb_TipoB_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_TipoB.Checked)
            {
                tipoConversion = "B";
            }
        }
    }
}