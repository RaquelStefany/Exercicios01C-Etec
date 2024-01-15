using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double L, C, A, P;

    //SAIDA DE DADOS
    Console.Write("Digite a Largura: ");
    L = double.Parse(Console.ReadLine());
    Console.Write("Digite o Comprimento: ");
    C = double.Parse(Console.ReadLine());
    Console.WriteLine();
    
    //PROCESSAMENTO E CALCULOS
    A = L * C;
    P = (L + C) * 2;
    Console.Write("{0} * {1} = {2}", L, C, A);
    Console.WriteLine();
    Console.Write("({0} + {1}) * 2 = {2}", L, C, P);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Area: {0}", A);
    Console.WriteLine();
    Console.Write("Perimetro: {0}", P);
  }
}