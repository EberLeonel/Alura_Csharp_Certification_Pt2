using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoExpandObject : IAulaItem
    {
        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\"," +
                "\"Para\": \"Guilherme Silveira\"}";


            //EnviarMensagem(JsonConvert.DeserializeObject<Mensagem>(json));
            dynamic vMessage = JsonConvert.DeserializeObject<ExpandoObject>(json);
            vMessage.Texto = "Olá, " + vMessage.Para;
            EnviarMensagem(vMessage);

            vMessage.Inverter = new Action(() =>
            {
                var vAux = vMessage.De;
                vMessage.De = vMessage.Para;
                vMessage.Para = vAux;                
                vMessage.Texto = "Olá, " + vMessage.Para;
            });

            vMessage.Inverter();
            EnviarMensagem(vMessage);
        }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }

    //class Mensagem
    //{
    //    public string De { get; set; }
    //    public string Para { get; set; }
    //    public string Texto { get; set; }
    //}


}
