using System;

namespace calculadora.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //vetores
            string[] historicoOperacaoes = new string[100];

            historicoOperacaoes[0]

            while(true)
            {
                Console.Clear();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("--------------------------------------");


                // subtrair v2

                Console.WriteLine("1 - Somar (+)");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("2 - Subtrair (-)");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("3 - Multiplicação (*)");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("4 - Divisão (/)");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(" Tabuada (T)");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Historico (H)");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Sair (S)");


                //Ex:Usar para sair.
                // if (opcao == "s")
                // break;

                //para for (int contador = 1; contador <= 10; contador ++) 

                string opcao = Console.ReadLine();

                if (opcao == "s")
                {
                    break;
                }

                else if (opcao == "T")
                {

                    Console.WriteLine("O-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-O");
                    Console.WriteLine("-----------------TABUADA-----------------");
                    Console.WriteLine("O-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-O");
                    Console.Write("Qual tabuada vamos ver?...");
                    int numerot = Convert.ToInt32(Console.ReadLine());

                    //for= para 
                    //ele precisa de um contador
                    // variavel de controle
                    for (int contador = 1; contador <= 20; contador++)
                    {
                        int R_multiplicacao = numerot * contador;


                        string linhaDaTabuada = numerot + " x " + contador + " = " + R_multiplicacao;
                        Console.WriteLine(linhaDaTabuada);
                    }

                        Console.ReadLine();
                    continue;
                }


                Console.WriteLine(".");
                Console.Write("primeiro número: ");

                string srtnumero1 = Console.ReadLine();
                Console.WriteLine(".");
                Console.Write(" segundo número: ");
                string srtnumero2 = Console.ReadLine();


                decimal numero1 = Convert.ToInt32(srtnumero1);
                decimal numero2 = Convert.ToInt32(srtnumero2);
                decimal numero3 = Convert.ToInt32(srtnumero2);
                decimal numero4 = Convert.ToInt32(srtnumero2);

                decimal resultado = 0.0m;

                //Numeros decimais (com casas)
                //decimal resultadoDouble= 0.0; //16 casas
                // float resultadofloat = 0.0f;  //6 casas                      // Cada um tem uma quantia de casa que agenta.
                // decimal resultadoDecimal = 0.0m; // 32 casas


                //estrutura de  decição
                if (opcao == "+")
                {
                    //soma
                    resultado = numero1 + numero2;
                }
                else if (opcao == "-")
                {
                    //subtração
                    resultado = numero1 - numero2;
                }
                else if (opcao == "*")
                {
                    //multiplicação
                    resultado = numero1 * numero2;
                }
                else if (opcao == "/")
                {
                    //divisão

                    if(numero2== 0 )
                    {
                        Console.Write("---------------------------------");
                        Console.Write("(Não é possivem dividir por zero)");
                        Console.Write("---------------------------------");
                       Console.ReadLine();
                      continue;
                    }

                    resultado = numero1 / numero2;
                }
              


                    Console.WriteLine("------------------------------------------");


                Console.WriteLine("Resultado: " + resultado);


                Console.ReadLine();
            }
        }
    }
}
