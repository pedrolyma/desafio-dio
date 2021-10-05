// conversao de tempo
// inteiro, que é o tempo de duração em segundos de um  
// determinado evento em uma loja, e informe-o expresso  
// no formato horas:minutos:segundos.

// Entrada
// O arquivo de entrada contém um valor inteiro N.

// Saída
// Imprima o tempo lido no arquivo de entrada  
// (segundos), convertido para horas:minutos:segundos,  
// conforme exemplo fornecido.
import java.util.Scanner;

public class Main {
     public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int tempo = input.nextInt();
        int hour = (tempo / 3600);
        int min = (tempo % 3600) / 60;
        int sec = (tempo % 3600) % 60;
        System.out.println(hour+":"+min+ ":"+sec);
    }
}
