using Microsoft.AspNetCore.Components;

namespace MzTech.Pages
{
    public partial class NavMenu : ComponentBase
    {
        [Parameter] public string BrandName { get; set; } = "MZ Tech";

        public class NavLinkItem
        {
            public string Text { get; set; } = string.Empty;
            public string Href { get; set; } = string.Empty;
            public bool IsActive { get; set; } = false;
        }

        protected List<NavLinkItem> NavLinks = new()
        {
            new() { Text = "Home", Href = "/", IsActive = true },
            new() { Text = "Projects", Href = "#projects" },
            new() { Text = "Contact", Href = "#contact" },
            new() { Text = "About", Href = "/about" }
        };
    }
}
