#pragma checksum "D:\Работа\Test\Test\Pages\Profil.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "197f71f6a03874e49ec22baed8c52a08f8ddbcdb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "D:\Работа\Test\Test\Pages\Profil.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/personsPage/{profilmyvalue}")]
    public partial class Profil : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Работа\Test\Test\Pages\Profil.razor"
       
    private MySqlDbContext context = new MySqlDbContext();

    [Parameter]
    public string profilmyvalue { get; set; }

    private string firstName;
    private string secondName;
    private string email;
    private string pmail;

    protected override void OnInitialized()
    {
        defaultInput();
        base.OnInitialized();
    }

    private void defaultInput()
    {
        firstName = context.Persons.Find(Convert.ToInt32(profilmyvalue)).FirstName;
        secondName = context.Persons.Find(Convert.ToInt32(profilmyvalue)).SecondName;
        email = context.Persons.Find(Convert.ToInt32(profilmyvalue)).Email;
        pmail = context.Persons.Find(Convert.ToInt32(profilmyvalue)).Password;
    }

    private bool IsValidEmail(string emaill)
    {
        string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
        var regex = new Regex(pattern, RegexOptions.IgnoreCase);
        return regex.IsMatch(emaill);
    }

    private void saveChanges()
    {
        if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(secondName) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(pmail))
        {
            if (pmail.Length >= 6 && IsValidEmail(email))
            {
                var person = context.Persons.Find(Convert.ToInt32(profilmyvalue));

                person.FirstName = firstName;
                person.SecondName = secondName;
                person.Email = email;
                person.Password = pmail;

                context.SaveChanges();
            }
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591