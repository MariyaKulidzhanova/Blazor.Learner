#pragma checksum "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7460d69e18c83eb42a0d4f348a5e66396d1f04b"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Learner.Client.Shared.Company
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Blazor.Learner.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Blazor.Learner.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Blazor.Learner.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Blazor.Learner.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/company")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Companies</h3>\r\n");
            __builder.AddMarkupContent(1, "<small>Add as many companies as you wish.</small>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"form-group\">\r\n    <a class=\"btn btn-success\" href=\"company/create\"><i class=\"oi oi-plus\"></i> Create New</a>\r\n</div>\r\n<br>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
 if (companies == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "Loading...");
#nullable restore
#line 14 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
                           
}
else if (companies.Length == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "No Records Found.");
#nullable restore
#line 18 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-striped");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Name</th>\r\n                <th>Email</th>\r\n                <th>Years</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 33 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
             foreach (Company dev in companies)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 36 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
                         dev.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 37 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
                         dev.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 38 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
                         dev.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 39 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
                         dev.Years

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "btn btn-success");
            __builder.AddAttribute(31, "href", "company/edit/" + (
#nullable restore
#line 41 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
                                                                       dev.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
                                                                   () => Delete(dev.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 45 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 49 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Shared\Company\FetchData.razor"
       
    Company[] companies { get; set; }
    protected override async Task OnInitializedAsync()
    {
        companies = await client.GetFromJsonAsync<Company[]>("api/company");
    }

    async Task Delete(int developerId)
    {
        var dev = companies.First(x => x.Id == developerId);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {dev.Name}'s ({dev.Id}) Record?"))
        {
            await client.DeleteAsync($"api/company/{developerId}");
            await OnInitializedAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
