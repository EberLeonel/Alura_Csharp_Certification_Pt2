using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            String vText = "R$ 13,45";

            decimal.TryParse(vText,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out decimal vConverted);
        }
    }
}
