using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double vDivida = 1_234_567_890.123;
            long vCopia = (long)vDivida;
            Console.WriteLine(vCopia.GetType());


            Animal vAnimal = new Gato();
            Gato vGato = (Gato)vAnimal; //Cast = conversão explícita
            Console.WriteLine(vGato.GetType());
        }
    }
}
