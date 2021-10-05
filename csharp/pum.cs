// Pum
// Desafio
// Desenvolva um programa que leia um valor inteiro N. Este N refere-se à quantidade de linhas de saída que serão apresentadas na execução do programa.
// Entrada
// O arquivo de entrada contém um número inteiro positivo N.
// Saída
// Imprima a saída conforme o exemplo fornecido.
using System;

namespace TESTE {
    class Program {
        static void Main(string[] args) {
        
            int N = int.Parse(Console.ReadLine());
                                                                                                                                                          
            int primeiro = 1;
            for (int i = 1; i <= N*4; i++) {
               primeiro++;
               if (primeiro > 4) {
                  Console.WriteLine(" PUM");
                  primeiro = 1;
              } else {
                  Console.Write("{0} ", i);
              }

            }
        }
    }
}
