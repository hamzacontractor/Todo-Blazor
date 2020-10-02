using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Blazored.LocalStorage;

using TodoBlazorApp.Models;
using TodoBlazorApp.Pages;

namespace TodoBlazorApp
{
   //public class Logic
   //{
   //   public async Task AddNewCatagory(TodoCatagoryModel catagory, ILocalStorageService localStore)
   //   {
   //      Data.Stored.Add(catagory);
   //      Data.Displayed.Add(catagory);

   //      await SaveDisplayedToLocalStore(localStore);
   //      await SaveStoredToLocalStore(localStore);
   //   }

   //   public async Task RemoveCatagory(TodoCatagoryModel catagory, ILocalStorageService localStore)
   //   {
   //      Data.Displayed.Remove(catagory);
   //      Data.Stored.Remove(catagory);

   //      await SaveDisplayedToLocalStore(localStore);
   //      await SaveStoredToLocalStore(localStore);
   //   }



   //   public async Task SaveTodoToStored(TodoClass todo, ILocalStorageService localStore)
   //   {
   //      TodoCatagoryModel todoCatagory = Data.Stored
   //                                           .Find(x => x.Name == todo.CatagoryName);

   //      todoCatagory.TotalTimeSpan.Add(todo.TimeSpan);

   //      todoCatagory.Todos.Add(todo);

   //      switch (todoCatagory.SpanUnit)
   //      {
   //         case 'M':
   //            todoCatagory.AverageTimeSpan = (todoCatagory.TotalTimeSpan.TotalMinutes / todoCatagory.Todos.Count).ToString("###.##") + " Minutes";
   //            break;
   //         case 'H':
   //            todoCatagory.AverageTimeSpan = (todoCatagory.TotalTimeSpan.TotalHours / todoCatagory.Todos.Count).ToString("###.##") + " Hours";
   //            break;
   //         case 'D':
   //            todoCatagory.AverageTimeSpan = (todoCatagory.TotalTimeSpan.TotalDays / todoCatagory.Todos.Count).ToString("###.##") + " Days";
   //            break;
   //         default:
   //            return;
   //      }

   //      await SaveStoredToLocalStore(localStore);
   //   }

   //   public async Task SaveStoredToLocalStore(ILocalStorageService localStore)
   //   {
   //      await localStore.SetItemAsync("stored", Data.Stored);
   //   }

   //   public async Task<List<TodoCatagoryModel>> GetStoredFromLocalStore(ILocalStorageService localStore)
   //   {
   //      return await localStore.GetItemAsync<List<TodoCatagoryModel>>("displayed");
   //   }

      

   //   public async Task AddTodoInDisplay(TodoClass todo, ILocalStorageService localStore)
   //   {
   //      TodoCatagoryModel todoCatagory = Data.Displayed
   //                                           .Find(x => x.Name == todo.CatagoryName);
   //      todoCatagory.Todos.Add(todo);

   //      await SaveDisplayedToLocalStore(localStore);
   //   }

   //   public async Task RemoveTodoFromDisplayed(TodoClass todo, ILocalStorageService localStore)
   //   {
   //      Data.Displayed
   //          .Find(x => x.Name == todo.CatagoryName)
   //          .Todos.Remove(todo);

   //      await SaveDisplayedToLocalStore(localStore);
   //   }

   //   public async Task SaveDisplayedToLocalStore(ILocalStorageService localStore)
   //   {
   //      await localStore.SetItemAsync("displayed", Data.Displayed);
   //   }

   //   public async Task<List<TodoCatagoryModel>> GetDisplayedFromLocalStore(ILocalStorageService localStore)
   //   {
   //      return await localStore.GetItemAsync<List<TodoCatagoryModel>>("displayed");
   //   }
   //}
}
