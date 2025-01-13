using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFive.Models
{
  public class BaseClass
  {
    protected int field1;
    protected int field2;

    public virtual void PrintFields()
    {
      Console.WriteLine($"Field1: {field1}, Field2: {field2}");
    }
  }
}
