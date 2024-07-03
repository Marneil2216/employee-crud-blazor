using EmployeeWebServer.Data;

namespace EmployeeWebServer.Components.Pages
{
    public partial class EmployeeList
    {
        string nameFilter = "";
        string addressFilter = "";
        string emailFilter = "";
        string phoneFilter = "";
        List<Employee> EmpObj;
        List<Employee> _filteredEmployees = new();
        bool open = false;

        protected override async Task OnInitializedAsync()
        {
            EmpObj = await Task.Run(() => employeesService.GetAllEmployees());
        }

        void ToggleDrawer()
        {
            open = !open;
        }
    }
}
