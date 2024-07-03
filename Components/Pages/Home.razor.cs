namespace EmployeeWebServer.Components.Pages
{
    public  partial class Home
    {
        bool open = false;

        void ToggleDrawer()
        {
            open = !open;
        }
    }
}
