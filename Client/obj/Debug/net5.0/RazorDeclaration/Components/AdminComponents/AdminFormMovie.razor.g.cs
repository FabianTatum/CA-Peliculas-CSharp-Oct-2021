// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CrAgPeliculas.App.Client.Components.AdminComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.MoviesComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.StaffComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.AdminComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Components.CategoryComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\_Imports.razor"
using CrAgPeliculas.App.Client.Helpers;

#line default
#line hidden
#nullable disable
    public partial class AdminFormMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "c:\2.PersonalProjects\ProyectoCreativeAgencyPeliculas.io\CrAgPeliculas.App\Client\Components\AdminComponents\AdminFormMovie.razor"
      

    [Parameter] public Movie Movie {get;set;}
    [Parameter] public EventCallback OnValidSubmit {get;set;}
    [Parameter] public List<Staff> NotSelectedStaff { get; set; }
    [Parameter] public List<Staff> SelectedStaff { get; set; }
    [Parameter] public List<Category> NotSelectedCategories { get; set; }
    [Parameter] public List<Category> SelectedCategories { get; set; }

    public List<MultiSelectorModel> NotSelectedStaffMulti { get; set; }
    public List<MultiSelectorModel> SelectedStaffMulti { get; set; }
    public List<MultiSelectorModel> NotSelectedCategoriesMulti { get; set; }
    public List<MultiSelectorModel> SelectedCategoriesMulti { get; set; }

    string ImageUrlBackdrop;
    string ImageUrlPoster;

    protected override void OnInitialized()
    {

        NotSelectedStaffMulti = NotSelectedStaff.Select( s => new MultiSelectorModel( s.Id.ToString(), s.Name)).ToList();
        SelectedStaffMulti = SelectedStaff.Select( s => new MultiSelectorModel( s.Id.ToString(), s.Name)).ToList();
        NotSelectedCategoriesMulti = NotSelectedCategories.Select( c => new MultiSelectorModel( c.Id.ToString(), c.Name)).ToList();
        SelectedCategoriesMulti = SelectedCategories.Select( c => new MultiSelectorModel( c.Id.ToString(), c.Name)).ToList();

        if( !string.IsNullOrEmpty(Movie.Backdrop) )
        {
            ImageUrlBackdrop = Movie.Backdrop;
            Movie.Backdrop = null;
        }

        if( !string.IsNullOrEmpty(Movie.Poster) )
        {
            ImageUrlPoster = Movie.Poster;
            Movie.Poster = null;
        }
       
    }

    private void ImageBackdrop(string imageB64)
    {
        Movie.Backdrop = imageB64;
        ImageUrlBackdrop = null;
    }

    private void ImagePoster(string imageB64)
    {
        Movie.Poster = imageB64;
        ImageUrlPoster = null;
    }

    private async Task OnDataAnnotationsValidated()
    {
        Movie.MovieCategory = SelectedCategoriesMulti.Select( c => new MovieCategory { CategoryId = int.Parse(c.Key) }).ToList();
        Movie.StaffMovie = SelectedStaffMulti.Select( s => new StaffMovie { StaffId = int.Parse(s.Key) }).ToList();

        if(!String.IsNullOrWhiteSpace(Movie.Poster))
        {
           ImageUrlBackdrop = null; 
           ImageUrlPoster = null; 
        }

        await OnValidSubmit.InvokeAsync(null);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
