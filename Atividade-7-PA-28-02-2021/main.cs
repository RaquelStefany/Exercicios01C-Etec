using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //DECLARAÇÃO DE VARIAVEIS
    double R, PI, VOL;

    //SAIDA DE DADOS
    Console.Write("Digite o Raio da Esfera: ");
    R = double.Parse(Console.ReadLine());
    Console.WriteLine();
    PI = Math.PI;

    //PROCESSAMENTO E CALCULOS
    VOL = (4 / 3) * Math.PI * Math.Pow(R,3);
    Console.Write("(4 / 3) * {0} * {1} = {2}", PI, R, VOL);
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("O Volume da Esfera é: {0}", VOL);
  }
}