using EmployeeWebServer.Data;
using Microsoft.AspNetCore.Components;

namespace EmployeeWebServer.Components.Pages
{
    public partial class EditEmployee
    {
        bool open=false;
        [Parameter]
        public string Id { get; set; }
        Employee obj = new Employee();

        protected override async Task OnInitializedAsync()
        {
            obj = await Task.Run(() => employeeService.GetEmployeeById(Convert.ToInt32(Id)));
        }
        protected async void UpdateEmployee()
        {
            await employeeService.UpdateEmployeeDetails(obj);
            NavigationManager.NavigateTo("Employees");
        }
        protected async void Cancel()
        {
            NavigationManager.NavigateTo("Employees");
        }

         void ToggleDrawer()
        {
            open = !open;
        }
    }
}
