using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj)
        {
            //    Animal animal = obj as Animal; //se não consegue converter, seta nulo 

            //    //if (obj is IAnimal)
            //    //{
            //    //   animal = (Animal)obj;
            //    //}

            //    if (animal == null)
            //    {
            //        Console.WriteLine("obj não é uma animal");
            //        return;
            //    }

            //    animal.Beber();
            //    animal.Comer();

            if (obj is Animal vAnimal)
            {
                vAnimal.Beber();
                vAnimal.Comer();
                return;
            }
            Console.WriteLine("obj não é um animal");
        }
    }
}
