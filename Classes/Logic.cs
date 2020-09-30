using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Blazored.LocalStorage;

using TodoBlazorApp.Models;
using TodoBlazorApp.Pages;

namespace TodoBlazorApp
{
   public class Logic
   {
      private readonly ILocalStorageService localStore;

      public Logic(ILocalStorageService _localStore)
      {
         localStore = _localStore;
      }



      public async Task AddNewCatagory(TodoCatagoryModel catagory)
      {
         Data.Displayed.Add(catagory);
         await SaveDisplayedToLocalStore();

         Data.Stored.Add(catagory);
         await SaveStoredToLocalStore();
      }

      public async Task RemoveCatagory(TodoCatagoryModel catagory) {

         Data.Displayed.Remove(catagory);
         await SaveDisplayedToLocalStore();

         Data.Stored.Remove(catagory);
         await SaveStoredToLocalStore();
      }
      


      public async Task SaveTodoToStored(TodoClass todo)
      {
         TodoCatagoryModel todoCatagory = Data.Stored
                                              .Find(x => x.Name == todo.CatagoryName);

         todoCatagory.TotalTimeSpan.Add(todo.TimeSpan);

         todoCatagory.Todos.Add(todo);

         switch (todoCatagory.SpanUnit)
         {
            case 'M':
               todoCatagory.AverageTimeSpan = (todoCatagory.TotalTimeSpan.TotalMinutes / todoCatagory.Todos.Count).ToString("###.##") + " Minutes";
               break;
            case 'H':
               todoCatagory.AverageTimeSpan = (todoCatagory.TotalTimeSpan.TotalHours / todoCatagory.Todos.Count).ToString("###.##") + " Hours";
               break;
            case 'D':
               todoCatagory.AverageTimeSpan = (todoCatagory.TotalTimeSpan.TotalDays / todoCatagory.Todos.Count).ToString("###.##") + " Days";
               break;
            default:
               return;
         }

         await SaveStoredToLocalStore();
      }

      public async Task SaveStoredToLocalStore()
      {
         await localStore.SetItemAsync("stored", Data.Stored);
      }

      public async Task<List<TodoCatagoryModel>> GetStoredFromLocalStore()
      {
         return await localStore.GetItemAsync<List<TodoCatagoryModel>>("displayed");
      }



      public async Task AddTodoInDisplay(TodoClass todo)
      {
         Data.Displayed
             .Find(x => x.Name == todo.CatagoryName)
             .Todos.Add(todo);

         await SaveDisplayedToLocalStore();
      }

      public async Task RemoveTodoFromDisplayed(TodoClass todo)
      {
         Data.Displayed
             .Find(x => x.Name == todo.CatagoryName)
             .Todos.Remove(todo);

         await SaveDisplayedToLocalStore();
      }

      public async Task SaveDisplayedToLocalStore()
      {
         await localStore.SetItemAsync("displayed", Data.Displayed);
      }

      public async Task<List<TodoCatagoryModel>> GetDisplayedFromLocalStore()
      {
         return await localStore.GetItemAsync<List<TodoCatagoryModel>>("displayed");
      }
   }
}
