using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using TodoBlazorApp.Models;

namespace TodoBlazorApp
{
   public static class Data
   {
      public static TodoClass Todo { get; set; } = new TodoClass();
      public static bool ShowCatagory { get; set; } = false;
      public static List<TodoCatagoryModel> Displayed { get; set; } = new List<TodoCatagoryModel>();
      public static List<TodoCatagoryModel> Stored { get; set; } = new List<TodoCatagoryModel>();
   }
}
