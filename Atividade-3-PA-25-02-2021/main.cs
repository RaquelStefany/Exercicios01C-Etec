using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double PR, D, PRD;

    //SAIDA DE DADOS
    Console.Write("Digite o Valor: ");
    PR = double.Parse(Console.ReadLine());
    Console.WriteLine();

    //PROCESSAMENTO E CALCULOS
    D = PR * 5 / 100;
    PRD = PR - D;
    Console.Write("{0} * 5 / 100 = {1}", PR, D);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("{0} - {1} = {2}", PR, D, PRD);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Valor do Desconto: {0}", D);
  }
}