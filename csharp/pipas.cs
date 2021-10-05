// apesar de ser crianca bastante criativa e astuta, guilher nao sabe como determinar a
// quantidade de barbantes que ele tera que utilizar para tornar uma pipa de n lados estavel.

// a entrada sera composta por uma univa linha que contem um inteiro representando o numero de lados.

// saida imprima um numero inteiro que sera a quant de barbante.

using System;
class TESTE {
   static void Main(string[] args) {
       int p = int.Parse(Console.ReadLine());
           long r, aux = 0;
           if(p == 3)
               Console.WriteLine(0);
           else if(p == 4)
               Console.WriteLine(2);
           else

           {
               for (int i = 2; i < p - 1; i++)

               {
                   r = aux + i;
                   aux = r;
               }
               Console.WriteLine(aux);
           }

   }
}