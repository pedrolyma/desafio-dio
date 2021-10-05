// Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N =  
// N * (N-1) * (N-2) * (N-3) * ... * 1.

// Entrada
// A entrada contém um valor inteiro N (0 < N < 13).

// Saída
// A saída contém um valor inteiro, correspondente ao fatorial de N.

package main.java.com.desafios.dio;
import java.util.Scanner;

public class Fatorial {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N, fatorial =0;
        N = sc.nextInt();
        fatorial=N;
        while (N > 1) {
			fatorial=fatorial*(N-1);
			N--;
		}
        System.out.println(fatorial);
    }
}