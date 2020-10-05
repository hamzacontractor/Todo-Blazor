using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoBlazorApp.Models
{
   public class TodoClass
   {
      public string Text { get; set; } = "";
      public DateTime TimeAdded { get; set; } = new DateTime();
      public DateTime TimeCompleted { get; set; } = new DateTime();
      public bool Done { get; set; } = false;
      //public TimeSpan TimeSpan { get; set; } = new TimeSpan();
      //public string CatagoryName { get; set; } = "";

   }
}
