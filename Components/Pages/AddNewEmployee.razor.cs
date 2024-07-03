using EmployeeWebServer.Data;

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

