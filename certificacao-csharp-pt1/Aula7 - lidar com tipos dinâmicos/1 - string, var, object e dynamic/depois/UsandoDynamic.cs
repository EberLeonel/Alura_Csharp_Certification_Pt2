using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            String vText = "Certigficação C#";
            var vSecondText = "Certigficação C#";
            object vThirdText = "Certigficação C#";

            vText.ToUpper();
            vSecondText.ToUpper();
            vThirdText = ((String)vThirdText).ToUpper();

            //vText = 123;
            //vSecondText = 123;
            vThirdText = 123;

            vThirdText = (int)vThirdText + 4;

            Console.WriteLine(vThirdText);

            //dynamic é o único tipo que é definido em tempo de execução
            dynamic vFourthText = "Certificação C#";
            vFourthText = vFourthText.ToUpper();

            Console.WriteLine(vFourthText);

            vFourthText = 123;


        }
    }
}
