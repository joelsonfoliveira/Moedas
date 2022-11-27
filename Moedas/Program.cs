using System.Globalization;

namespace Moedas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      decimal valor = 10536.25m;

      System.Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
    }
  }
}