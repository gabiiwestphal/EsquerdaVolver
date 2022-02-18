using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroComandos;
            char sentido = 'N';
            String comandos;

            Console.WriteLine("Digite o número de comandos: ");
            numeroComandos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os comandos: ");
            comandos = Console.ReadLine();

            char[] serieDeComandos = comandos.ToCharArray();

            for (int i = 0; i < serieDeComandos.Length; i++)
            {
                var instrucao = serieDeComandos[i];

                if (instrucao != 'D' && instrucao != 'E')
                {
                    Console.WriteLine("ERRO");
                }

               
                if (instrucao == 'E')
                {
                    if (sentido == 'N') sentido = 'O';

                    else if (sentido == 'O') sentido = 'S';

                    else if (sentido == 'S') sentido = 'L';                  
                                           
                    else if (sentido == 'L') sentido = 'N';                   
                                           
                }

                else if (instrucao == 'D')
                {
                    if (sentido == 'N') sentido = 'L';                   
                                            
                    else if (sentido == 'L') sentido = 'S';                   
                                           
                    else if (sentido == 'S') sentido = 'O';                  
                                           
                    else if (sentido == 'O') sentido = 'N';                                        
                    
                }
            }
            Console.WriteLine(sentido);
            Console.ReadLine();
        }
    }
}
