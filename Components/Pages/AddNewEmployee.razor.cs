using EmployeeWebServer.Data;
using MudBlazor;

namespace EmployeeWebServer.Components.Pages
{
    public partial class AddNewEmployee
    {
        
        bool open= false;
        Employee obj = new Employee();

        protected async void CreateNewEmployee()
        {
            await employeeService.AddNewEmployee(obj);
            NavigationManager.NavigateTo("Employees");
            Snackbar.Add("Added Successfully", Severity.Success);
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

