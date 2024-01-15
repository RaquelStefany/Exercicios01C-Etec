using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double PR, D, VD, PAG;

    //SAIDA DE DADOS
    Console.Write("Digite o Preço do Produto: ");
    PR = double.Parse(Console.ReadLine());
    Console.Write("Digite o Valor do Desconto: ");
    D = double.Parse(Console.ReadLine());
    Console.WriteLine();

    //PROCESSAMENTO E CALCULOS
    VD = PR * D / 100;
    PAG = PR - VD;
    Console.Write("{0} * {1} / 100 = {2}", PR, D, VD);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("{0} - {1} = {2}", PR, VD, PAG);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Valor do Produto com Desconto: {0}", PAG);
  }
}