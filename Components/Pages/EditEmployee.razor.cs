using EmployeeWebServer.Data;
using Microsoft.AspNetCore.Components;
using MudBlazor;

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
            Snackbar.Add("Updated Successfully", Severity.Success);
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
