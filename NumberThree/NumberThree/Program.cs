using NumberThree.Models;

namespace NumberThree
{
  internal class Program
  {
    static void Main(string[] args)
    {
      DateTime currentDate = new DateTime(2023, 4, 15);
      string result = currentDate.ToStringFromCreationOfTheWorld();
      Console.WriteLine(result);
      Console.ReadKey();
    }
  }
}

