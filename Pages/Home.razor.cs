using Microsoft.AspNetCore.Components;

namespace MzTech.Pages
{
    public partial class Home
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public void NavigateToAbout()
        {
            NavigationManager.NavigateTo("/ApplicationDetails");
        }
    }
}
