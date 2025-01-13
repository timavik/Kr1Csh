using NumberFour.Models;

namespace NumberFour
{
  internal class Program
  {
    static void Main(string[] args)
    {
      MyStack stack = new MyStack(5);
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      if (stack.Pop(out int value))
        Console.WriteLine(value); 

      if (stack.Pop(out value))
        Console.WriteLine(value); 

      if (stack.Pop(out value))
        Console.WriteLine(value); 

      if (!stack.Pop(out value))
        Console.WriteLine("Стек пуст"); 

      Console.ReadKey();
    }
  }
}
