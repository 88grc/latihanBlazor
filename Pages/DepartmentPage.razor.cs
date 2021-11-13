using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UTS.Models;
using UTS.Services;

namespace UTS.Pages
{
    public partial class DepartmentPage
    {
        public List<Department> Departments { get; set; } = new List<Department>();
        [Inject]
        public IDEPartmentService DepartmentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetAll()).ToList();
        }
    }
}