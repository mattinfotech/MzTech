using Microsoft.AspNetCore.Components;

namespace MzTech.Components
{
    public partial class ProjectCard
    {
        [Parameter] public string Title { get; set; } = string.Empty;
        [Parameter] public string Description { get; set; } = string.Empty;
        [Parameter] public string ImageUrl { get; set; } = string.Empty;
        [Parameter] public string DetailsUrl { get; set; } = string.Empty;
        [Parameter] public string? GitHubUrl { get; set; }

        private string ModalId
        {
            get
            {
                var key = $"{Title}-{DetailsUrl}";
                var safeKey = new string(key.Where(char.IsLetterOrDigit).ToArray()).ToLowerInvariant();
                return $"project-preview-{(string.IsNullOrWhiteSpace(safeKey) ? "image" : safeKey)}";
            }
        }
    }
}