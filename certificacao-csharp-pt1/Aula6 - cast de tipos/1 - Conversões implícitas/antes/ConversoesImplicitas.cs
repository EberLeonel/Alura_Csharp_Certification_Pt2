using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {

            int vInteger = 2_123_456_79;
            long vLongInteger = vInteger;

            vInteger = (int)vLongInteger;


            Gato vCat = new Gato();
            Animal vAnimal = vCat;

            Console.WriteLine(vAnimal.GetType());

            IAnimal vIAnimal = (IAnimal)vCat;
            Console.WriteLine(vIAnimal.GetType());

            //vCat = vIAnimal;
        }
    }
}

