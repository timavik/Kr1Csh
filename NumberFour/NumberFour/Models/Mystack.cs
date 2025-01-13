using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFour.Models
{
  public class MyStack
  {
    private int[] _stack;
    private int _top;

    public MyStack(int size)
    {
      _stack = new int[size];
      _top = -1;
    }

    public bool Push(int value)
    {
      if (_top == _stack.Length - 1)
        return false;

      _stack[++_top] = value;
      return true;
    }

    public bool Pop(out int value)
    {
      if (_top == -1)
      {
        value = 0;
        return false; 
      }

      value = _stack[_top--];
      return true;
    }
  }
}
