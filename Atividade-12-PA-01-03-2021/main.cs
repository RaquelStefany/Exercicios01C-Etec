using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double A, B, C, D;
    
    //PROCESSAMENTO E CALCULOS
    A = 2;
    B = 4;
    C = (A + B) * B;
    D = C * B / (A + A);
    A = D / (C + B);
    B = 4 + 2;
    Console.Write("A Variavel A Vale: {0}", A);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("A Variavel B Vale: {0}", B);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("A Variavel C Vale: {0}", C);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("A Variavel D Vale: {0}", D);
  }
}