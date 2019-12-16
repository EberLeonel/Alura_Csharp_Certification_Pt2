using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int number = 57;
            object box = number;
            Console.WriteLine(string.Concat("Resposta", number, true));
            try
            {
                int unboxed = (int)box;
            }
            catch (Exception) {}
        }
    }
}
