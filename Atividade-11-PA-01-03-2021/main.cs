using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double QTD, CT, LT, CP, LP;

    //SAIDA DE DADOS
    Console.Write("Digite o Comprimento do Tijolo: ");
    CT = double.Parse(Console.ReadLine());
    Console.Write("Digite a Largura do Tijolo: ");
    LT = double.Parse(Console.ReadLine());
    Console.Write("Digite o Comprimento da Parede: ");
    CP = double.Parse(Console.ReadLine());
    Console.Write("Digite a Largura da Parede: ");
    LP = double.Parse(Console.ReadLine());
    Console.WriteLine();

    //PROCESSAMENTO E CALCULOS
    QTD = (CP * LP) / (CT * LT);
    Console.Write("({0} * {1}) / ({2} * {3}) = {4}", CP, LP, CT, LT, QTD);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("São Necessarios " + Math.Round(QTD, 0) + " Tijolos");
  }
}