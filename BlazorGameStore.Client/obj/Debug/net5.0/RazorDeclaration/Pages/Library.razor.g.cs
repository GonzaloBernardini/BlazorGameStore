// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorGameStore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using BlazorGameStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
using BlazorGameStore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\_Imports.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\gbern\Desktop\GONZA\Programacion\DOTNET\BlazorGameStore\BlazorGameStore.Client\Pages\Library.razor"
 
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
