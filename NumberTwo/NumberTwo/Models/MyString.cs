using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTwo.Models
{
  public class MyString
  {
    private char[] _chars;

    public MyString()
    {
      _chars = new char[0];
    }

    public MyString(string str)
    {
      _chars = str.ToCharArray();
    }

    public MyString(char[] chars)
    {
      _chars = new char[chars.Length];
      Array.Copy(chars, _chars, chars.Length);
    }

    public void Reverse()
    {
      Array.Reverse(_chars);
    }

    public override string ToString()
    {
      return new string(_chars);
    }
  }
}
