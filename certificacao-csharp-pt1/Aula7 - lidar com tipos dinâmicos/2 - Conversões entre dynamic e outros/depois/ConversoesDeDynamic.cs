using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            dynamic vOne = 7;
            dynamic vTwo = DateTime.Now;
            dynamic vThree = new List<int>() { 132, 456, 789 };

            int vFirst = vOne;
            DateTime vSecond = vTwo;
            List<int> vThird = vThree;

            vThird = vTwo;//Conversão com erro em tempo de execução
        }
    }
}
