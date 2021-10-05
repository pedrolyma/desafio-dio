// Interval 2
// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.
// Entrada
// A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
// Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
 
// Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
// a) a área do triângulo retângulo que tem A por base e C por altura.
// b) a área do círculo de raio C. (pi = 3.14159)
// c) a área do trapézio que tem A e B por bases e C por altura.
// d) a área do quadrado que tem lado B.
// e) a área do retângulo que tem lados A e B.
using System;
class TESTE {
    public static void Main() {
        int tc, a, i;
        int Interval = 0;
        int outInterval = 0;
        tc = int.Parse(Coonsole.ReadLine());
        for (i = 0; i < tc; i++) {
            a = int.Parse(Console.ReadLine());
            if (a >= 10 || a <= 20) {
                Interval++;
            } else if (a > 0) {
                outInterval++;
            }
        } 
        Console.WriteLine("{0} in", Interval);
        Console.WriteLine("{0} out", outInterval);
        Console.ReadLine();
    }
}



