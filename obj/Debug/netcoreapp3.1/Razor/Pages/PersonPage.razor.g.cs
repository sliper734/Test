#pragma checksum "D:\Работа\Test\Test\Pages\PersonPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10120e561c61c88646b86e57e28ff345a8d15896"
// <auto-generated/>
#pragma warning disable 1591
namespace Test.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Работа\Test\Test\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Работа\Test\Test\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Работа\Test\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Работа\Test\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Работа\Test\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Работа\Test\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Работа\Test\Test\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Работа\Test\Test\_Imports.razor"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Работа\Test\Test\_Imports.razor"
using Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Работа\Test\Test\_Imports.razor"
using Test.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Работа\Test\Test\Pages\PersonPage.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/personsPage")]
    public partial class PersonPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row was-validated");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-3 custom-control");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<label for=\"fname\">Имя</label>\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "id", "fname");
            __builder.AddAttribute(14, "placeholder", "Имя");
            __builder.AddAttribute(15, "required", true);
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                                                                                        firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<div class=\"valid-feedback\">\r\n                Отлично!\r\n            </div>\r\n            ");
            __builder.AddMarkupContent(20, "<div class=\"invalid-feedback\">\r\n                Заполните поле!\r\n            </div>\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-3 custom-control");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<label for=\"sname\">Фамилия</label>\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "placeholder", "Фамилия");
            __builder.AddAttribute(30, "id", "sname");
            __builder.AddAttribute(31, "required", true);
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                                                                                            secondName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => secondName = __value, secondName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<div class=\"valid-feedback\">\r\n                Отлично!\r\n            </div>\r\n            ");
            __builder.AddMarkupContent(36, "<div class=\"invalid-feedback\">\r\n                Заполните поле!\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-3 custom-control");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<label for=\"ename\">Email</label>\r\n            ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "type", "email");
            __builder.AddAttribute(45, "placeholder", "Email");
            __builder.AddAttribute(46, "id", "ename");
            __builder.AddAttribute(47, "pattern", ".+.com");
            __builder.AddAttribute(48, "required", true);
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                                                                                                            email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.AddMarkupContent(52, "<div class=\"valid-feedback\">\r\n                Отлично!\r\n            </div>\r\n            ");
            __builder.AddMarkupContent(53, "<div class=\"invalid-feedback\">\r\n                Заполните поле!\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-3");
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.AddMarkupContent(58, "<label for=\"pname\">Пароль</label>\r\n            ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "class", "form-control");
            __builder.AddAttribute(61, "type", "password");
            __builder.AddAttribute(62, "placeholder", "Password");
            __builder.AddAttribute(63, "pattern", "[A-Za-z-0-9]{6,}");
            __builder.AddAttribute(64, "id", "pname");
            __builder.AddAttribute(65, "required", true);
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                                                                                                                            pmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pmail = __value, pmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.AddMarkupContent(69, "<div class=\"valid-feedback\">\r\n                Отлично!\r\n            </div>\r\n            ");
            __builder.AddMarkupContent(70, "<div class=\"invalid-feedback\">\r\n                Заполните поле!\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "row");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "class", "btn btn-secondary");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                                                        AddPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(82, "Добавить");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "row");
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col");
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.OpenElement(92, "table");
            __builder.AddAttribute(93, "class", "table table-striped");
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.AddMarkupContent(95, @"<thead class=""table-dark"">
                    <tr>
                        <th scope=""col"">ID</th>
                        <th scope=""col"">Имя</th>
                        <th scope=""col"">Фамилия</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(96, "tbody");
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 67 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                     foreach (Person item in context.Persons)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                        ");
            __builder.OpenElement(99, "tr");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                                      (()=>Href(item.ID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(101, "\r\n                            ");
            __builder.OpenElement(102, "td");
            __builder.AddMarkupContent(103, "\r\n                                ");
            __builder.AddContent(104, 
#nullable restore
#line 71 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                                 item.ID

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(105, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "td");
            __builder.AddMarkupContent(108, "\r\n                                ");
            __builder.AddContent(109, 
#nullable restore
#line 74 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                                 item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(110, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.OpenElement(112, "td");
            __builder.AddMarkupContent(113, "\r\n                                ");
            __builder.AddContent(114, 
#nullable restore
#line 77 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                                 item.SecondName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(115, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 80 "D:\Работа\Test\Test\Pages\PersonPage.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "D:\Работа\Test\Test\Pages\PersonPage.razor"
       
    private MySqlDbContext context = new MySqlDbContext();
    private string firstName;
    private string secondName;
    private string email;
    private string pmail;

    private bool IsValidEmail(string emaill)
    {
        string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
        var regex = new Regex(pattern, RegexOptions.IgnoreCase);
        return regex.IsMatch(emaill);
    }

    private void Href(int profilid)
    {
        navigationManager.NavigateTo($"/personsPage/{profilid}");
    }

    private void AddPerson()
    {
        if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(secondName) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(pmail))
        {
            if (pmail.Length >= 6 && IsValidEmail(email))
            {
                Person person = new Person
                {
                    FirstName = firstName,
                    SecondName = secondName,
                    Email = email,
                    Password = pmail
                };
                context.Persons.Add(person);
                context.SaveChanges();
                /*firstName = string.Empty;
                secondName = string.Empty;
                email = string.Empty;*/
            }

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
