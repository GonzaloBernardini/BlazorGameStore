#pragma checksum "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\Pages\Library.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "702d5cddf90c9c62e963f33a7affbb5298f3c896"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorGameStore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using BlazorGameStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using BlazorGameStore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\_Imports.razor"
using shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/library")]
    public partial class Library : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "library");
            __builder.OpenElement(2, "main");
#nullable restore
#line 4 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\Pages\Library.razor"
     if (gameList != null && gameList.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\Pages\Library.razor"
         foreach (var item in gameList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "class", "game-card");
            __builder.AddAttribute(5, "href", "#");
            __builder.OpenElement(6, "article");
            __builder.OpenElement(7, "div");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 11 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\Pages\Library.razor"
                                   item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "h3");
            __builder.AddContent(12, 
#nullable restore
#line 13 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\Pages\Library.razor"
                         item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.AddMarkupContent(14, "<p><span class=\"jam jam-download\"></span>\r\n                        <span>Descargar</span></p>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\Pages\Library.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\Pages\Library.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.client\Pages\Library.razor"
 
    List<Game> gameList = new List<Game>();

    protected override async Task OnInitializedAsync()
    {
        gameList.Add(new Game()
        {
            Title = "Rocket League",
            Description = "Described as 'soccer, but with rocket-powered cars', Rocket League has up to eight players assigned to each of the two teams, using rocket-powered vehicles to hit a ball into their opponent's goal and score points over the course of a match.",
            Image = "https://as01.epimg.net/meristation/imagenes/2020/09/23/noticias/1600849560_494635_1600849813_portada_normal.jpg",
            Price = 15.0M,
            Discount = 0.6M
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
