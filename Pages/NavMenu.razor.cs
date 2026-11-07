using Microsoft.AspNetCore.Components;

namespace MzTech.Pages
{
    public partial class NavMenu : ComponentBase, IDisposable
    {
        [Parameter] public string BrandName { get; set; } = "MZ Tech";

        [Inject] private NavigationManager Navigation { get; set; } = default!;
        private bool IsMenuOpen { get; set; }

        protected override void OnInitialized()
        {
            Navigation.LocationChanged += OnLocationChanged;
        }

        private void ToggleMenu() => IsMenuOpen = !IsMenuOpen;
        private void CloseMenu() => IsMenuOpen = false;

        private bool IsActive(string href)
        {
            var current = new Uri(Navigation.Uri);
            return href switch
            {
                "/" => current.AbsolutePath == "/" && current.Fragment.Length == 0,
                "/#projects" => current.Fragment == "#projects" ||
                    (current.AbsolutePath != "/" && current.AbsolutePath != "/about" && current.AbsolutePath != "/contact"),
                "/#contact" => current.Fragment == "#contact" || current.AbsolutePath == "/contact",
                _ => current.AbsolutePath == href
            };
        }

        private void OnLocationChanged(object? sender, Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs args)
        {
            CloseMenu();
            _ = InvokeAsync(StateHasChanged);
        }

        public void Dispose() => Navigation.LocationChanged -= OnLocationChanged;

        public class NavLinkItem
        {
            public string Text { get; set; } = string.Empty;
            public string Href { get; set; } = string.Empty;
        }

        protected List<NavLinkItem> NavLinks = new()
        {
            new() { Text = "Home", Href = "/" },
            new() { Text = "Projects", Href = "/#projects" },
            new() { Text = "Contact", Href = "/#contact" },
            new() { Text = "About", Href = "/about" }
        };
    }
}
