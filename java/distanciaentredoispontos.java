// Distancia entre dois pontos

// Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, conforme a fórmula:
// Distancia = 
// Entrada
// O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.
// Saída
// Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

import java.io.IOException;
import java.util.Scanner;

public class Problem {
	
  public static void main(String[] args) throws IOException {
    Scanner leitor = new Scanner(System.in);
    double X1 = leitor.nextDouble();
    double Y1 = leitor.nextDouble();    
    double X2 = leitor.nextDouble();
    double Y2 = leitor.nextDouble();
    double p1 = X2 - X1;
    double p2 = Y2 - Y1;
    double resultado = ((p1 * p1) + (p2 * p2));
    System.out.println(String.format("%.4f", Math.sqrt(resultado)));

    }
	
}
