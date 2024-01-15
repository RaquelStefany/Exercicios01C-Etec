using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    /*Não possui nenhum codigo indicando os valores das variaveis A, B e C, portando não tem como o algoritmo executar o programa.*/
    /*O certo deveria ser:*/

    //DECLARAÇÃO DAS VARIAVEIS
    int B, RESULTADO;

    //SAIDA DE DADOS
    Console.Write("Digite o Valor de B: ");
    B = int.Parse(Console.ReadLine());

    //PRECESSAMENTO E CALCULOS

    /*(A-B)*A/3;*/

    RESULTADO = B - 100;
    Console.Write("O Resultado da Operação foi: {0}", RESULTADO);
  }
}