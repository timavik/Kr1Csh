using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberThree.Models
{
  public static class DateTimeExtensions
  {
    public static string ToStringFromCreationOfTheWorld(this DateTime dateTime)
    {
      string[] monthNames = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня",
                                "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };

      int year = dateTime.Year + 5508;
      int month = dateTime.Month - 1;
      int day = dateTime.Day;

      return $"День '{day}' месяца '{monthNames[month]}' года '{year}' от сотворения мира.";
    }
  }
}
