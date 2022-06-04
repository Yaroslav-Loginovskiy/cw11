// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace cw11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using cw11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using cw11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using cw11.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\_Imports.razor"
using cw11.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Yaroslav\Desktop\PJATK\APBD\cw11\cw11\cw11\Pages\Students.razor"
       
    private List<Student> students;

    protected override void OnInitialized()
    {
        students = StudentService.Students;
    }

    private async Task Show(int ID)
    {
        await JsRuntime.InvokeVoidAsync("show", ID);
    }

    private async Task Decline()
    {
        await JsRuntime.InvokeVoidAsync("decline");
    }

    private async Task Accept()
    {
        await JsRuntime.InvokeVoidAsync("accept");
    }

    private async Task DeleteStudent(int ID)
    {
        students.Remove(repository.GetStudent(ID));
        repository.DeleteStudent(ID);
        await Accept();
    }

    private bool order = true;
    private void SortByFirstName()
    {
        if (order == true)
        {
            students = students.OrderBy(student => student.FirstName).ToList();
            order = false;
        }
        else
        {
            students = students.OrderByDescending(students => students.FirstName).ToList();
            order = true;
        }
    }

    private void SortByLastName()
    {
        if (order == true)
        {
            students = students.OrderBy(student => student.LastName).ToList();
            order = false;
        }
        else
        {
            students = students.OrderByDescending(students => students.LastName).ToList();
            order = true;
        }
    }

    private void SortByBirthDate()
    {
        if (order == true)
        {
            students = students.OrderBy(student => student.BirthDate).ToList();
            order = false;
        }
        else
        {
            students = students.OrderByDescending(students => students.BirthDate).ToList();
            order = true;
        }
    }

    private void SortByStudies()
    {
        if (order == true)
        {
            students = students.OrderBy(student => student.Studies).ToList();
            order = false;
        }
        else
        {
            students = students.OrderByDescending(students => students.Studies).ToList();
            order = true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService repository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
