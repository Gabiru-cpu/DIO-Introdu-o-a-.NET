using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace BibliotecaDeClasses.common.Models
{
    public class Calculadora
    {
        int chave=0;
        double x, y, angulo, valorRaiz;
        string resposta;
        
        public void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Quer realizar qual operação?\nEnvie numero:\n1.somar \n2.Subtrair \n3.multiplicação \n4.dividir \n5.Modulo \n6.Potencia \n7.Funções trigonométricas \n8.Raiz Quadrada \n9.Sair");
                
                do
                {
                    Console.WriteLine("Digite o número da opção desejada:");
                    resposta = Console.ReadLine();
                } while (   resposta != "1" && 
                            resposta != "2" && 
                            resposta != "3" && 
                            resposta != "4" && 
                            resposta != "5" &&
                            resposta != "6" &&
                            resposta != "7" &&
                            resposta != "8" &&
                            resposta != "9");
                
                chave = Convert.ToInt32(resposta);
                if(chave == 7) 
                {
                    ReceberAngulo();
                }
                else if (chave == 8) { ReceberRaiz(); }
                else if (chave == 9) { Environment.Exit(0); }
                else
                {
                    ReceberValores();
                }
                
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
                        Trigonometria();
                    break;
                    case 8:
                        RaizQuadrada();
                        break;
                    default:
                    break;
                }

            } while (chave > 9 || chave < 1);


        }

        public void ReceberValores()
        {
            Console.WriteLine("Envie o primeiro valor");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Envie o segundo valor");
            y = Convert.ToDouble(Console.ReadLine());
        }
        public void ReceberAngulo()
        {
            Console.WriteLine("Envie o valor do angulo");
            angulo = Convert.ToDouble(Console.ReadLine());
        }
        public void ReceberRaiz()
        {
            Console.WriteLine("Envie o valor do número que quer a raiz quadrada");
            valorRaiz = Convert.ToDouble(Console.ReadLine());
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

        public void Trigonometria() 
        {
            Seno();
            Coseno();
            Tangente();
        }
        void Seno()
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }

        void Coseno()
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }

        void Tangente()
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada()
        {
            double raiz = Math.Sqrt(valorRaiz);
            Console.WriteLine($"Raiz quadrada de {valorRaiz} = {raiz}");
        } 
    }
}