using System;
namespace Comparacao
{
  class Program
  {
    static void Main(string[] args)
    {
      var texto = "esse texto é um teste?";

      System.Console.WriteLine(texto.Contains("este teste"));
      System.Console.WriteLine(texto.Contains("Teste"));
      System.Console.WriteLine(texto.Contains("teste", StringComparison.OrdinalIgnoreCase));

    }
  }

}

