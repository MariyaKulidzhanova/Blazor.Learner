#pragma checksum "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb6da82114c45e2cd60ae981e80c7f8b54ce21b5"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Learner.Client.Pages.Authentication
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"h2 font-weight-normal login-title\">\r\n    Login\r\n</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "class", "form-signin");
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor"
                                             OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor"
                                                              loginRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.AddMarkupContent(9, "<label for=\"inputUsername\" class=\"sr-only\">User Name</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "id", "inputUsername");
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "autofocus", true);
                __builder2.AddAttribute(14, "placeholder", "Username");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor"
                                                                    loginRequest.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.UserName = __value, loginRequest.UserName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __Blazor.Blazor.Learner.Client.Pages.Authentication.Login.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 15 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor"
                              () => loginRequest.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n\r\n    ");
                __builder2.AddMarkupContent(22, "<label for=\"inputPassword\" class=\"sr-only\">Password</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "type", "password");
                __builder2.AddAttribute(25, "id", "inputPassword");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "placeholder", "Password");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor"
                                                                                                           loginRequest.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.Password = __value, loginRequest.Password))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginRequest.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __Blazor.Blazor.Learner.Client.Pages.Authentication.Login.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 19 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor"
                              () => loginRequest.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(34, "\r\n\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-check m-3");
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(38);
                __builder2.AddAttribute(39, "id", "inputRememberMe");
                __builder2.AddAttribute(40, "class", "form-check-input");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor"
                                                                                   loginRequest.RememberMe

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginRequest.RememberMe = __value, loginRequest.RememberMe))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => loginRequest.RememberMe));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.AddMarkupContent(45, "<label class=\"form-check-label\" for=\"inputRememberMe\">Remember Me</label>\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n    ");
                __builder2.AddMarkupContent(47, "<button class=\"btn btn-lg btn-primary btn-block\" type=\"submit\">Sign in</button>\r\n\r\n    ");
                __builder2.OpenElement(48, "label");
                __builder2.AddAttribute(49, "class", "text-danger");
                __builder2.AddContent(50, 
#nullable restore
#line 28 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor"
                                error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(52);
                __builder2.AddAttribute(53, "href", "register");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(55, "\r\n        ");
                    __builder3.AddMarkupContent(56, "<h6 class=\"font-weight-normal text-center\">Create account</h6>\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\adam\source\Intera\Blazor.Learner wirh authentication\Client\Pages\Authentication\Login.razor"
      
    LoginRequest loginRequest { get; set; } = new LoginRequest();
    string error { get; set; }

    async Task OnSubmit()
    {
        error = null;
        try
        {
            await authStateProvider.Login(loginRequest);
            navigationManager.NavigateTo("");
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.Blazor.Learner.Client.Pages.Authentication.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591