#pragma checksum "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\TrailerMoviesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8846c051375a0efb8720426175b5a761c72baf3"
// <auto-generated/>
#pragma warning disable 1591
namespace CrAgPeliculas.App.Client.Components.MoviesComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.MoviesComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.StaffComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.AdminComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.CategoryComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Helpers;

#line default
#line hidden
#nullable disable
    public partial class TrailerMoviesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\TrailerMoviesComponent.razor"
 if (TypeOfButtonTrailer == "Card")
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "target", "_blank");
            __builder.AddAttribute(2, "href", 
#nullable restore
#line 3 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\TrailerMoviesComponent.razor"
                              RedirectTrailer

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "class", "btn btn-success btn-lg");
            __builder.AddContent(4, "Trailer");
            __builder.CloseElement();
#nullable restore
#line 4 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\TrailerMoviesComponent.razor"
}
else if(TypeOfButtonTrailer == "Poster")
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "target", "_blank");
            __builder.AddAttribute(7, "href", 
#nullable restore
#line 7 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\TrailerMoviesComponent.razor"
                              RedirectTrailer

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "class", "btn btn-success btn-sm");
            __builder.AddContent(9, "Trailer");
            __builder.CloseElement();
#nullable restore
#line 8 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\TrailerMoviesComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\MoviesComponents\TrailerMoviesComponent.razor"
      
    
    [Parameter] public string RedirectTrailer { get; set; }
    [Parameter] public string TypeOfButtonTrailer { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
