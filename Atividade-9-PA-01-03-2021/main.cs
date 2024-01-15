using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double VAL_REAL, VAL_DOLAR, COT;

    //SAIDA DE DADOS
    Console.Write("Quantidade de Dolares Guardados: " );
    VAL_DOLAR = double.Parse(Console.ReadLine());
    Console.Write("Cotação do Dolar Hoje: " );
    COT = double.Parse(Console.ReadLine());
    Console.WriteLine();

    //PROCESSAMENTO E CALCULOS
    VAL_REAL = VAL_DOLAR * COT;
    Console.Write("{0} * {1} = {2}", VAL_DOLAR, COT, VAL_REAL);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Você Possui {0} em Reais", VAL_REAL);
  }
}