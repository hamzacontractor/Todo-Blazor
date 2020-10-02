#pragma checksum "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adff7bf7636f1b957a192b66f87ecc851801b499"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using TodoBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using TodoBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Blazor Apps\Todo Blazor App\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
using Models;

#line default
#line hidden
#nullable disable
    public partial class TodoCatagory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
 if (Data.Displayed.Count > 0)
{
    foreach (TodoCatagoryModel todoCatagory in Data.Displayed)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-12 p-4 mt-5 priority-container");
            __builder.AddMarkupContent(3, "\r\n            ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "type", "button");
            __builder.AddAttribute(6, "class", "btn btn-outline-danger position-absolute border-0");
            __builder.AddAttribute(7, "style", "top:6px; right:4px;");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
                                                                                                                                  (e => { RemoveCatagory(todoCatagory); Console.WriteLine(e.Type); })

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "h4");
            __builder.AddContent(12, 
#nullable restore
#line 14 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
                 todoCatagory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 15 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
             if (todoCatagory.Todos.Count > 0)
            {
                foreach (TodoClass thisTodo in todoCatagory.Todos)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-12");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenComponent<TodoBlazorApp.Pages.TodoComponent>(18);
            __builder.AddAttribute(19, "ThisTodo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TodoBlazorApp.Models.TodoClass>(
#nullable restore
#line 20 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
                                                  thisTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 22 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "            ");
            __builder.OpenElement(23, "p");
            __builder.AddContent(24, "Average Completion Time: ");
            __builder.AddContent(25, 
#nullable restore
#line 24 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
                                         todoCatagory.AverageTimeSpan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 26 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Blazor Apps\Todo Blazor App\Pages\TodoCatagory.razor"
      
    protected override Task OnInitializedAsync()
    {

        var timer = new Timer(new TimerCallback(x =>
        {
            this.StateHasChanged();
        }), DateTime.Now, 100, 100);

        return base.OnInitializedAsync();
    }

    async Task RemoveCatagory(TodoCatagoryModel todoCatagory)
    {
        Data.Stored.Remove(todoCatagory);
        await localStore.SetItemAsync("stored", Data.Stored);

        Data.Displayed.Remove(todoCatagory);
        await localStore.SetItemAsync("displayed", Data.Displayed);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStore { get; set; }
    }
}
#pragma warning restore 1591