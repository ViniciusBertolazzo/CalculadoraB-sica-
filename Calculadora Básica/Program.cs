using System;

namespace ComputadorMelhor
{
    class Program
    {
        //2.CALCULADORA BÁSICA

        static void Main(string[] args)
        {
            void ExibirLogo()
            {
                Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██║░░██║██║░░██║██████╔╝███████║
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░░██████╗██╗░█████╗░░█████╗░
██╔══██╗██╔══██╗██╔════╝██║██╔══██╗██╔══██╗
██████╦╝███████║╚█████╗░██║██║░░╚═╝███████║
██╔══██╗██╔══██║░╚═══██╗██║██║░░██╗██╔══██║
██████╦╝██║░░██║██████╔╝██║╚█████╔╝██║░░██║
╚═════╝░╚═╝░░╚═╝╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝");
            }
            int numero;
            Menu();

            void Menu()
            {
                ExibirLogo();
                Console.WriteLine("\nDigite o número da opção que deseja escolher");
                Console.WriteLine("\nDigite o número 1 se desejar acessar a calculadora de SOMA");
                Console.WriteLine("Digite o número 2 se deseja acessar a calculadora de SUBTRAÇÃO");
                Console.WriteLine("Digite o número 3 se deseja acessar a calculadora de MULTIPLICAÇÃO");
                Console.WriteLine("Digite o número 4 se deseja acessar a calculadora de DIVISÃO");
                Console.WriteLine("\nAperte a tecla 5 se deseja fechar a calculadora básica");
                int numero = int.Parse(Console.ReadLine());
                
                switch (numero)
                {

                    case 1:
                        Console.Clear();
                        MenuDeSoma();
                        break;

                    case 2:
                        Console.Clear();
                        MenuDeSubtracao(); 
                        break;

                    case 3:
                        Console.Clear();
                        MenuDeMultiplicacao();
                        break;

                    case 4:
                        Console.Clear();
                        MenuDeDivisao();
                        break;

                    case 5:
                        Console.WriteLine("Tchau tchau :) !!!");
                        break;

                    default:
                        Console.WriteLine("Valor inválido!!! \n\nDigite outro número...");

                        Thread.Sleep(1500);
                        Console.Clear();
                        Menu();
                        break;
                }
                void MenuDeSoma()
                {
                    
                    Console.WriteLine("**********************");
                    Console.WriteLine("Calculadora de soma");
                    Console.WriteLine("**********************");
                    float valor1;
                    float valor2;
                    float equacao;
                    int tecla1;

                    Console.Write("\nDigite um valor: " );
                    valor1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite outro valor: ");
                    valor2 = float.Parse(Console.ReadLine());
                    equacao = (valor1 + valor2);
                    Console.WriteLine("\nO valor da soma {0} + {1} é igual a: {2}" ,valor1,valor2,equacao );
                    Thread.Sleep(1000);
                    Console.WriteLine("\nDigite 1 para voltar ao menu principal");
                    Console.WriteLine("Ou digite 2 para continuar na calculadora de soma");
                    tecla1 = int.Parse(Console.ReadLine());
                    if(tecla1==1)
                    {
                        Console.Clear();
                        Menu();
                       
                    }
                    if (tecla1 == 2)
                    {

                        Console.Clear();
                        MenuDeSoma();
                    }


                }
                void MenuDeSubtracao()
                {
                    Console.WriteLine("**********************");
                    Console.WriteLine("Calculadora de subtração");
                    Console.WriteLine("**********************");
                    float valor1;
                    float valor2;
                    float equacao;
                    int tecla1;

                    Console.Write("\nDigite um valor: ");
                    valor1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite outro valor: ");
                    valor2 = float.Parse(Console.ReadLine());
                    equacao = (valor1 - valor2);
                    Console.WriteLine("\nO valor da subtração {0} - {1} é igual a: {2}", valor1, valor2, equacao);
                    Thread.Sleep(1000);
                    Console.WriteLine("\nDigite 1 para voltar ao menu principal");
                    Console.WriteLine("Ou digite 2 para continuar na calculadora de subtração");
                    tecla1 = int.Parse(Console.ReadLine());
                    if (tecla1==1)
                    {
                        Console.Clear();
                        Menu();
                       
                    }
                    if (tecla1 == 2)
                    {

                        Console.Clear();
                        MenuDeSubtracao();
                    }
                }
                void MenuDeMultiplicacao()
                {
                    Console.WriteLine("**********************");
                    Console.WriteLine("Calculadora de multiplicação");
                    Console.WriteLine("**********************");
                    float valor1;
                    float valor2;
                    float equacao;
                    int tecla1;

                    Console.Write("\nDigite um valor: ");
                    valor1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite outro valor: ");
                    valor2 = float.Parse(Console.ReadLine());
                    equacao = (valor1 * valor2);
                    Console.WriteLine("\nO valor da multiplicação {0} x {1} é igual a: {2}", valor1, valor2, equacao);
                    Thread.Sleep(1000);
                    Console.WriteLine("\nDigite 1 para voltar ao menu principal");
                    Console.WriteLine("Ou digite 2 para continuar na calculadora de multiplicação");
                    tecla1 = int.Parse(Console.ReadLine());

                    if (tecla1 == 1)
                    {
                        Console.Clear();
                        Menu();

                    }
                    if (tecla1 == 2)
                    {

                        Console.Clear();
                        MenuDeMultiplicacao();
                    }
                }
                void MenuDeDivisao()
                {
                    Console.WriteLine("**********************");
                    Console.WriteLine("Calculadora de divisão");
                    Console.WriteLine("**********************");
                    float valor1;
                    float valor2;
                    float equacao;
                    int tecla1;

                    Console.Write("\nDigite um valor: ");
                    valor1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite outro valor: ");
                    valor2 = float.Parse(Console.ReadLine());
                    equacao = (valor1 / valor2);
                    Console.WriteLine("\nO valor da divisão {0} / {1} é igual a: {2}", valor1, valor2, equacao);
                    Thread.Sleep(1000);
                    Console.WriteLine("\nDigite 1 para voltar ao menu principal");
                    Console.WriteLine("Ou digite 2 para continuar na calculadora de divisão");
                    tecla1 = int.Parse(Console.ReadLine());
                    if (tecla1 == 1)
                    {
                        Console.Clear();
                        Menu();

                    }
                    if (tecla1 == 2)
                    {

                        Console.Clear();
                        MenuDeDivisao();
                    }
                }



            }










        }
    }
}
