using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double A, B;

    //SAIDA DE DADOS
    Console.Write("Digite o Valor de A: ");
    A = double.Parse(Console.ReadLine());
    Console.Write("Digite o Valor de B: ");
    B = double.Parse(Console.ReadLine());
    Console.WriteLine();

    //PROCESSAMENTO E CALCULOS
    Console.Write("A = {0}", B);
    Console.WriteLine();
    Console.Write("B = {0}", A);
  }
}