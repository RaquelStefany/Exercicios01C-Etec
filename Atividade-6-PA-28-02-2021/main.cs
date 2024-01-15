using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double AA, AN, I;

    //SAIDA DE DADOS
    Console.Write("Digite o Ano Atual: ");
    AA = double.Parse(Console.ReadLine());
    Console.Write("Digite o Ano de Nascimento: ");
    AN = double.Parse(Console.ReadLine());
    Console.WriteLine();

    //PROCESSAMENTO E CALCULOS
    I = AA - AN;
    Console.Write("{0} - {1} = {2}", AA, AN, I);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("A Idade é: {0} Anos", I);
  }
}