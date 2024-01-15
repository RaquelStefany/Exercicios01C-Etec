using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double HE, ME, HS, MS, HF, MF, PAG;

    //SAIDA DE DADOS
    Console.Write("Digite a Hora de Entrada: ");
    HE = double.Parse(Console.ReadLine());
    Console.Write("Digite o Minuto de Entrada: ");
    ME = double.Parse(Console.ReadLine());
    Console.Write("Digite a Hora de Saida: ");
    HS = double.Parse(Console.ReadLine());
    Console.Write("Digite o Minuto de Saida ");
    MS = double.Parse(Console.ReadLine());
    Console.WriteLine();

    //PROCESSAMENTO E CALCULOS
    HF = (HS - HE) * 4;
    MF = (MS + 60 - ME) / 15;
    PAG = Math.Round(HF + MF);
    Console.Write("({0} - {1}) * 4 = {2}", HS, HE, HF);
    Console.WriteLine();
    Console.Write("({0} + 60 - {1}) / 15 = {2}", MS, ME, MF);
    Console.WriteLine();
    Console.Write("{0} + {1} = {2}", HF, MF, PAG);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("O Valor do Estacionamento é: R$ {0}", PAG);
  }
}