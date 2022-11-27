using System.Globalization;

namespace Moedas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      decimal valor = 10536.75m;

      System.Console.WriteLine(
        valor.ToString(
          "C", CultureInfo.CreateSpecificCulture("pt-BR")
        )
      ); // imprime em real do Brasil

      System.Console.WriteLine(
        String.Format(
          "{0:C}", valor
        )
      ); // imprime em real do Brasil

      System.Console.WriteLine(
        Math.Round(valor)
      ); // arredonda o valor para cima ou para baixo dependendo da aproximação

      System.Console.WriteLine(
        Math.Ceiling(valor)
      ); // arredonda o valor para cima

      System.Console.WriteLine(
        Math.Floor(valor)
      ); // arredonda o valor para baixo
    }
  }
}