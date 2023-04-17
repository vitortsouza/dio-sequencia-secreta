using System;

class Program 
{
  public static void Main() 
  {
    int tamanhoSequencia = Convert.ToInt32(Console.ReadLine());
    int quantidadeNumerosMarcados = 0;
    int ultimoNumeroLido = 0; // Inicializa em zero, porque "Vi é igual a 1 ou 2";
    for (int i = 0; i < tamanhoSequencia; i++) 
    {
      int vi = Convert.ToInt32(Console.ReadLine());
      //Verificar se o numero lido (Vi) é diferente do último numero lido para marcá-lo.
      if (vi != ultimoNumeroLido)
      {
        quantidadeNumerosMarcados += 1;
      }
      ultimoNumeroLido = vi;
    }
    //Imprimir a quantidade de números marcados.
    Console.WriteLine(quantidadeNumerosMarcados);
  }
}