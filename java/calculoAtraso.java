// Todos os domingos, Bino faz compras na feira. Ele sempre marca com seu amigo  
// Cino de se encontrarem no terminal de ônibus da Parangaba às 8h, para irem  
// juntos comprar na feira. Porém, muitas vezes Bino acorda muito tarde e se  
// atrasa para o encontro com seu amigo.

// Sabendo que Bino leva de 30 a 60 minutos para chegar ao terminal. Diga o  
// atraso máximo de Bino.

// Entrada

// A entrada consiste em múltiplos casos teste. Cada caso de tese contém uma  
// única 
// linha contendo um horário H (5:00 ≤ H ≤ 9:00) que Bino acordou. 
// A entrada termina com final de arquivo (EOF).

// Fechou!!!! Era o calculo errado do atraso. 

// Meu script
import java.io.IOException;
import java.util.Scanner;

public class Desafio {
	
   public static void main(String[] args) throws IOException {
        Scanner leitor = new Scanner(System.in);
        int atraso = 0;

        while (leitor.hasNext()) {

            String[] relogio = leitor.nextLine().split(":");
            int hora = Integer.parseInt(relogio[0]);
            int min = Integer.parseInt(relogio[1]);

            if (hora == 7) {
              atraso = min;
            }
            if (hora == 8) {
              atraso = min + 60;
            }

            if (hora == 9) {
               atraso = 120;
            }

            switch (hora) {
                case (7): System.out.println("Atraso maximo: " + atraso); break;
                case (8): System.out.println("Atraso maximo: " +(Integer.parseInt(String.valueOf(atraso)))); break;
                case (9): System.out.println("Atraso maximo: " + (Integer.parseInt(String.valueOf(atraso)))); break;
                default: System.out.println("Atraso maximo: 0");
            }
        }
        leitor.close();
    }
}
