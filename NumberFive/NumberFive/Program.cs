using NumberFive.Models;

namespace NumberFive
{
  internal class Program : BaseClass
  {
    static void Main(string[] args)
    {
      BaseClass obj = new DerivedClass1(1, 2, 3);

      obj.PrintFields();

      Console.ReadKey();
    }
  }
}
