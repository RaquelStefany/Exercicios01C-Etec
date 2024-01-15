using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double L, C, A;

    //SAIDA DE DADOS
    Console.Write("Digite a Largura: ");
    L = double.Parse(Console.ReadLine());
    Console.Write("Digite o Comprimento: ");
    C = double.Parse(Console.ReadLine());
    Console.WriteLine();

    //PROCESSAMENTO E CALCULOS
    A = L * C;
    Console.Write("{0} * {1} = {2}", L, C, A);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Area: {0}", A);
  }
}