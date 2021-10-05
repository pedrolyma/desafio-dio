//Entrada
//A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.
//Saída
//Imprima o nome do animal correspondente à entrada fornecida.
using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
     string tipo1, tipo2, tipo3;
     tipo1 = Console.ReadLine(); //insira suas variaveis
     tipo2 = Console.ReadLine();
     tipo3 = Console.ReadLine();

    if ((tipo1 == "vertebrado") && (tipo2 == "ave" )  && (tipo3 == "carnivoro")) {
      Console.WriteLine("aguia");
    }
    if ((tipo1 == "vertebrado") && (tipo2 == "ave" )  && (tipo3 == "onivoro")) {
      Console.WriteLine("bomba");
    }
    if ((tipo1 == "vertebrado") && (tipo2 == "mamifero" )  && (tipo3 == "onivoro")) {
      Console.WriteLine("homem");
    }
    if ((tipo1 == "vertebrado") && (tipo2 == "mamifero" )  && (tipo3 == "herbivoro")) {
      Console.WriteLine("vaca");
    }
    
    if ((tipo1 == "invertebrado") && (tipo2 == "inseto" )  && (tipo3 == "hematofago")) {
      Console.WriteLine("pulga");
    }
    if ((tipo1 == "invertebrado") && (tipo2 == "inseto" )  && (tipo3 == "herbivoro")) {
      Console.WriteLine("lagarta");
    }
    if ((tipo1 == "invertebrado") && (tipo2 == "anelideo" )  && (tipo3 == "hematofago")) {
      Console.WriteLine("sanguessuga");
    }
    if ((tipo1 == "invertebrado") && (tipo2 == "anelideo" )  && (tipo3 == "onivoro")) {
      Console.WriteLine("minhoca");
    }

  }
}
