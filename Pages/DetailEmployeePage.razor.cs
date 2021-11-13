using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using UTS.Models;
using UTS.Services;

namespace UTS.Pages
{
    public partial class DetailEmployeePage
    {
        [Parameter]
        public string id { get; set; }
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public string Coordinate { get; set; }
        public string ButtonText { get; set; } = "Hide Footer";
        public string CssClass { get; set; } = null;
        protected void Button_Click(){
            if(ButtonText == "Hide Footer"){
                CssClass = "HideFooter";
                ButtonText = "Show Footer";
            }else{
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }
        protected void Mouse_Move(MouseEventArgs e){
            Coordinate = $"X = {e.ClientX}, Y = {e.ClientY}";
        }
        protected override async Task OnInitializedAsync(){
            id = id ?? "1";
            Employee = await EmployeeService.GetEmployee(Convert.ToInt32(id));
        }
    }
}