#pragma checksum "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d8f8561bc28fc56e603fa91eabac425c1293f64"
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
#line 2 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
using FrontBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addexcuse")]
    public partial class AddExcuse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<FrontBlazor.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "class", "testimonial py-5");
            __builder.AddAttribute(4, "id", "testimonial");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container-fluid");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, @"<div class=""col-md-4 py-5 bg-primary text-white text-center "">
                <div class="" "">
                    <div class=""card-body"">
                        <img src=""http://www.ansonika.com/mavia/img/registration_bg.svg"" style=""width:30%"">
                        <h2 class=""py-3"">Votre excuse</h2>
                        <p>
                            J'espère que vous avez une bonne raison !
                        </p>
                    </div>
                </div>
            </div>
            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-md-8 py-5");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "h-100");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.AddMarkupContent(19, "<h4 class=\"pb-4\">Merci de remplir ce formulaire</h4>\r\n                    ");
            __builder.OpenElement(20, "form");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(22);
            __builder.AddAttribute(23, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
                                          excuse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 30 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
                                                                 SaveExcuse

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-row");
                __builder2.AddMarkupContent(29, "\r\n                                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group col-md-12");
                __builder2.AddMarkupContent(32, "\r\n                                    ");
                __builder2.OpenElement(33, "textarea");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "required", true);
                __builder2.AddAttribute(36, "placeholder", "Raison");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
                                                                          excuse.Reason

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => excuse.Reason = __value, excuse.Reason));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "                            \r\n                            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-row");
                __builder2.AddMarkupContent(44, "\r\n                                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group col-md-12");
                __builder2.AddMarkupContent(47, "\r\n                                    ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "file");
                __builder2.AddAttribute(50, "class", "btn btn-primary");
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
                                                                                           UploadFile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "id", "fileUpload");
                __builder2.AddElementReferenceCapture(53, (__value) => {
#nullable restore
#line 38 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
                                                                                                             fileUpload = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n                            ");
                __builder2.AddMarkupContent(57, "<div class=\"form-row\">\r\n                                <input type=\"submit\" class=\"btn btn-primary\" value=\"S\'excuser\">\r\n                            </div>\r\n\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Axel8\Documents\EPSI\B3\DotNet\ProjetDotNet\FrontBlazor\FrontBlazor\Pages\AddExcuse.razor"
       
    public Excuse excuse { get; set; }
    public int _currentUserId { get; set; }

    ElementReference fileUpload;
    string imageData = String.Empty;

    async void UploadFile(ChangeEventArgs changeEventArgs)
    {
        var files = await fileReaderService.CreateReference(fileUpload).EnumerateFilesAsync();

        using (MemoryStream memoryStream = await files.First().CreateMemoryStreamAsync())
        {
            imageData = Convert.ToBase64String(memoryStream.ToArray());
            System.Diagnostics.Debug.Print(imageData);
        }
    }

    private void SaveExcuse()
    {
        ExcuseService _excuseService = new ExcuseService();
        excuse.Date = DateTime.Now;
        excuse.UserID = _currentUserId;
        excuse.Image = imageData;
        _excuseService.AddExcuse(excuse);
        NavigationManager.NavigateTo("/home");
    }

    protected override async void OnInitialized()
    {
                    excuse = new Excuse();

        //Permission
        _currentUserId = await ProtectedSessionStore.GetAsync<int>("id");
        if (_currentUserId == 0)
        {
            NavigationManager.NavigateTo("/");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
    }
}
#pragma warning restore 1591
