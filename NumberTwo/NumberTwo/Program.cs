using NumberTwo.Models;

namespace NumberTwo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      MyString ms1 = new MyString("Hello");
      Console.WriteLine(ms1.ToString());

      MyString ms2 = new MyString(new char[] { 'W', 'o', 'r', 'l', 'd' });
      Console.WriteLine(ms2.ToString());

      ms1.Reverse();
      Console.WriteLine(ms1.ToString());

      ms2.Reverse();
      Console.WriteLine(ms2.ToString());

Console.ReadKey();
    }
  }
}

