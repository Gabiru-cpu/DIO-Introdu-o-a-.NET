using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using System.Text.RegularExpressions;

namespace DIO_intro.NET.Models
{
    public class Calculadora
    {
        int chave=0;
        double x, y;
        string resposta;
        
        public void Main()
        {
            do
            {
                Console.WriteLine("Quer realizar qual operação?\nEnvie numero:\n1.somar \n2.Subtrair \n3.multiplicação \n4.dividir \n5.Modulo \n6.Potencia \n7.Sair");
                
                do
                {
                    Console.WriteLine("Digite o número da opção desejada:");
                    resposta = Console.ReadLine();
                } while (   resposta != "1" && 
                            resposta != "2" && 
                            resposta != "3" && 
                            resposta != "4" && 
                            resposta != "5" && 
                            resposta != "6");
                
                chave = Convert.ToInt32(resposta);

                ReceberValores();
                switch (chave)
                {
                    case 1:
                        Somar();
                        break;
                    case 2:
                        Subtracao();
                    break;
                    case 3:
                        Multiplicacao();
                    break;
                    case 4:
                        Divisao();
                    break;
                    case 5:
                        Modulo();
                    break;
                    case 6:
                        Potencia();
                    break;
                    case 7:
                        Environment.Exit(0);
                    break;
                    default:
                    break;
                }

            } while (chave > 6 || chave < 1);


        }

        public void ReceberValores()
        {
            Console.WriteLine("Envie o primeiro valor");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Envie o segundo valor");
            y = Convert.ToDouble(Console.ReadLine());
        }

        public void Somar()
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtracao()
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicacao()
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Divisao()
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Modulo()
        {
            Console.WriteLine($"{x} % {y} = {x % y}");
        }

        public void Potencia() 
        { 
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }  
    }
}