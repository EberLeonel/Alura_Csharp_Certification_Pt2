using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            String vText = "123";
            //int vNumberConverted = vText;
            int vNumberConverted = int.Parse(vText);
            Console.WriteLine(vNumberConverted);

            vText = "abc";
            //vNumberConverted = int.Parse(vText);
            int.TryParse(vText, out vNumberConverted);
            Console.WriteLine(vText);

            if(int.TryParse(vText, out vNumberConverted))
            {
                Console.WriteLine(vText);
            }
            else
            {
                Console.WriteLine("Esse não é um número");
            }

            vText = "R$ 13,45";

            decimal.TryParse(vText, 
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out decimal vConverted);
        }
    }
}
