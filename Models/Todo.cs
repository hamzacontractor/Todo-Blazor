using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo_Blazor_App.Models {
   public class Todo {
      public string Text { get; set; }
      public DateTime TimeAdded { get; set; }

      public string Priority { get; set; }


   }


}
