#pragma checksum "D:\Blazor Apps\Todo Blazor App\Pages\DateTimeComponant.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d5120784283bb131fb554ae505c1f6c28f9312"
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
#line 2 "D:\Blazor Apps\Todo Blazor App\Pages\DateTimeComponant.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class DateTimeComponant : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex text-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "D:\Blazor Apps\Todo Blazor App\Pages\DateTimeComponant.razor"
     current.ToString("dddd, dd MMMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex text-center");
            __builder.AddAttribute(8, "style", "font-size: 2.1em");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.AddContent(10, 
#nullable restore
#line 12 "D:\Blazor Apps\Todo Blazor App\Pages\DateTimeComponant.razor"
     current.ToString("h:mm:ss tt")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\Blazor Apps\Todo Blazor App\Pages\DateTimeComponant.razor"
       

    private DateTime current { get; set; } = DateTime.Now.AddHours(5.5);

    protected override async Task OnInitializedAsync()
    {
        var timer = new Timer(new TimerCallback(_ =>
        {
            current = DateTime.Now.AddHours(5.5);
            this.StateHasChanged();
        }), DateTime.Now, 500, 1000);

        await base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
