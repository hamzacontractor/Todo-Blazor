using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoBlazorApp.Models
{

   public class TodoCatagoryModel
   {

      public string Name { get; set; }
      public char SpanUnit { get; set; }
      public List<TodoClass> Todos { get; set; } = new List<TodoClass>();
      public long TotalSpan { get; set; }

      public TodoCatagoryModel()
      {
         Name = "";
         SpanUnit = new char();
      }
      public TodoCatagoryModel(string name, char spanUnit)
      {
         Name = name;
         SpanUnit = spanUnit;
      }
   }
}
