using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double DESC, PRECO, PRECOF, PVP;
  
    //SAIDA DE DADOS
    Console.Write("Digite o Preço do Produto com Desconto: ");
    DESC = double.Parse(Console.ReadLine());
    Console.Write("Digite o Preço Original: ");
    PRECO = double.Parse(Console.ReadLine());
    Console.WriteLine();

    //PROCESSAMENTO E CALCULOS
    PRECOF = DESC / PRECO * 100;
    PVP = 100 - PRECOF;
    Console.Write("{0} / {1} * 100 = {2}", DESC, PRECO, PRECOF);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("100 - {0} = {1}", PRECOF, PVP);

    /*Console.Write("Porcentagem de Desconto do Produto: {0} %(porcento)", PVP);*/

    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Porcentagem de Desconto do Produto: " + Math.Round(PVP, 0) + " %(porcento)");
  }
}