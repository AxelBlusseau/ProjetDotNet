#pragma checksum "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34b802918a6183f26a6df6a961dc6564b9b02d1a"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\_Imports.razor"
using FrontBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\_Imports.razor"
using FrontBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\Register.razor"
using FrontBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\Register.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "testimonial py-5");
            __builder.AddAttribute(2, "id", "testimonial");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, @"<div class=""col-md-4 py-5 bg-primary text-white text-center "">
                <div class="" "">
                    <div class=""card-body"">
                        <img src=""http://www.ansonika.com/mavia/img/registration_bg.svg"" style=""width:30%"">
                        <h2 class=""py-3"">Inscription</h2>
                        <p>
                            Cette application regroupe les meilleurs excuses de retard de ton campus, inscrit toi pour pouvoir rédiger toi même tes excuses et votes pour tes préférées !
                        </p>
                    </div>
                </div>
            </div>
            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-8 py-5");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "h-100");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<h4 class=\"pb-4\">Merci de remplir ce formulaire</h4>\r\n                    ");
            __builder.OpenElement(18, "form");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(20);
            __builder.AddAttribute(21, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\Register.razor"
                                          user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 25 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\Register.razor"
                                                               SaveUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-row");
                __builder2.AddMarkupContent(27, "\r\n                                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(30, "\r\n                                    ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "type", "email");
                __builder2.AddAttribute(34, "required", true);
                __builder2.AddAttribute(35, "placeholder", "Mail");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\Register.razor"
                                                                                    user.Mail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Mail = __value, user.Mail));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(42, "\r\n                                    ");
                __builder2.OpenElement(43, "input");
                __builder2.AddAttribute(44, "type", "password");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "required", true);
                __builder2.AddAttribute(47, "placeholder", "Mot de passe");
                __builder2.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\Register.razor"
                                                                                       user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-row");
                __builder2.AddMarkupContent(55, "\r\n                                ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group col-md-12");
                __builder2.AddMarkupContent(58, "\r\n                                    ");
                __builder2.OpenElement(59, "select");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "placeholder", "Classe");
                __builder2.AddAttribute(62, "required", true);
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\Register.razor"
                                                                        user.Grade

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Grade = __value, user.Grade));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(65, "\r\n                                        ");
                __builder2.OpenElement(66, "option");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                                        ");
                __builder2.OpenElement(68, "option");
                __builder2.AddAttribute(69, "value", "B1");
                __builder2.AddContent(70, "B1");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                                        ");
                __builder2.OpenElement(72, "option");
                __builder2.AddAttribute(73, "value", "B2");
                __builder2.AddContent(74, "B2");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                        ");
                __builder2.OpenElement(76, "option");
                __builder2.AddAttribute(77, "value", "B3");
                __builder2.AddContent(78, "B3");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                                        ");
                __builder2.OpenElement(80, "option");
                __builder2.AddAttribute(81, "value", "I4");
                __builder2.AddContent(82, "I4");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                        ");
                __builder2.OpenElement(84, "option");
                __builder2.AddAttribute(85, "value", "I5");
                __builder2.AddContent(86, "I5");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n\r\n                            ");
                __builder2.AddMarkupContent(91, "<div class=\"form-row\">\r\n                                <input type=\"submit\" class=\"btn btn-primary\" value=\"S\'inscrire\">\r\n                            </div>\r\n\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\r\n                ");
            __builder.AddMarkupContent(95, "<div>\r\n                    <a href=\"/\" style=\"position:absolute; bottom: 0; right: 20px;\" class=\"btn btn-primary\">Connexion</a>\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\Register.razor"
       
    public User user { get; set; }

    private async void SaveUser()
    {
        UserService _userService = new UserService();
        User result = await Task.Run(() => _userService.AddUser(user));
        await ProtectedSessionStore.SetAsync("id", result.Id);
        NavigationManager.NavigateTo("/home");
    }

    protected override void OnInitialized()
    {
        user = new User();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
    }
}
#pragma warning restore 1591
