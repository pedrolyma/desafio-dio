using System;

public class ValidaNota {
  static void Main() {
    int notasLidas = 0;
    bool opcao;
    double x = 0;
      
    while (notasLidas < 2) {
      opcao = true;
      double nota = double.Parse(Console.ReadLine());

      if (nota < 0 || nota > 10) {
        Console.WriteLine("nota invalida");
      } else if (notasLidas == 0) {
        x = nota;
        notasLidas++;
      } else if (notasLidas == 1) {
        double media = (x + nota) / 2;

        Console.Write("media = ");
        Console.WriteLine(media.ToString("N2"));
     
      } 
    }
  }
}