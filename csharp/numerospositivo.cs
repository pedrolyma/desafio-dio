//Números positivo
//Crie um programa que leia 6 valores. Você poderá receber valores negativos e/ou positivos como entrada, devendo desconsiderar os valores nulos. Em seguida, apresente a quantidade de valores positivos digitados.
//Entrada
//Você receberá seis valores, negativos e/ou positivos.
//Saída
//Exiba uma mensagem dizendo quantos valores positivos foram lidos assim como é exibido abaixo no exemplo de saída. Não esqueça da mensagem "valores positivos" ao final.
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
    {
        static void Main(string[] args)
        {
          List<double> arr = new List<double>(); 
          for (int i = 0; i < 6; i++) {
            double valor1 = double.Parse(Console.ReadLine());
            arr.Add(valor1);
          }
         int ehPositivo = arr.Where(x => x > 0.0).Count();
          Console.WriteLine(ehPositivo + " valores positivos");
        }
    }
