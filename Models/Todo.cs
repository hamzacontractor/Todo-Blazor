using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoBlazorApp.Models
{
   public class TodoClass
   {
      public string Text { get; set; }
      public DateTime TimeAdded { get; set; }
      public DateTime TimeCompleted { get; set; }
      public bool Done { get; set; }
      public TimeSpan TimeSpan { get; set; }
      public char SpanUnit { get; set; }
      public string CatagoryName { get; set; }
   }
}
