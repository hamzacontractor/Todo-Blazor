#pragma checksum "D:\Blazor Apps\Todo Blazor App\Pages\AddCatagory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "599748f448b38bd3ecf2f0c0d5718cf26c79fc20"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "D:\Blazor Apps\Todo Blazor App\Pages\AddCatagory.razor"
using TodoBlazorApp.Models;

#line default
#line hidden
#nullable disable
    public partial class AddCatagory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Blazor Apps\Todo Blazor App\Pages\AddCatagory.razor"
       
    private char TimeSpanUnit { get; set; } = 'H';
    private string CatagoryName { get; set; } = "";

    private async Task AddNewCatagory()
    {
        TodoCatagoryModel todoCatagory = new TodoCatagoryModel(CatagoryName, TimeSpanUnit);

        Data.Stored.Add(todoCatagory);
        Data.Displayed.Add(todoCatagory);

        await localStore.SetItemAsync("stored", Data.Stored);
        await localStore.SetItemAsync("displayed", Data.Displayed);
    }

    void HideAddNewCatagory()
    {
        Data.ShowCatagory = false;
    }

    void SetTimeSpanUnit(ChangeEventArgs e)
    {
        TimeSpanUnit = e.Value.ToString().ToCharArray()[0];
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStore { get; set; }
    }
}
#pragma warning restore 1591