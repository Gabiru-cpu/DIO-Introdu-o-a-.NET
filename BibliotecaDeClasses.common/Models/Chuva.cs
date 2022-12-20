using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaDeClasses.common.Models
{
    public class Chuva
    {
        public void Passear()
        {
            bool choveu = true, estaTarde = false; 

            if (!choveu && !estaTarde)
            {
                Console.WriteLine("Vou pedalar");
            } 
            else if (!choveu && estaTarde)
            {
                Console.WriteLine("Vou caminhar");
            }

            else 
            { 
                Console.WriteLine("Vou pedalar um outro dia");
            }
        }
    }
}