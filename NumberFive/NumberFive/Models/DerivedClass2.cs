using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFive.Models
{
  public class DerivedClass2 : BaseClass
  {
    private string field3;

    public DerivedClass2(int f1, int f2, string f3)
    {
      field1 = f1;
      field2 = f2;
      field3 = f3;
    }

    public override void PrintFields()
    {
      base.PrintFields();
      Console.WriteLine($"Field3: {field3}");
    }
  }
}
