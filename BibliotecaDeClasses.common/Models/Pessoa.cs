using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses.common.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Name}, e tenho {Age} anos");
        }
        public void HorarioeDia()
        {
            Console.WriteLine($"Data atual com adicional de uma semana");
            DateTime dataAtual = DateTime.Now.AddDays(7);
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
        }
    }

}
