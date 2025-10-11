using Microsoft.AspNetCore.Components;

namespace MzTech.Components
{
    public partial class ProjectCard
    {
        [Parameter] public string Title { get; set; } = string.Empty;
        [Parameter] public string Description { get; set; } = string.Empty;
        [Parameter] public string ImageUrl { get; set; } = string.Empty;
        [Parameter] public string DetailsUrl { get; set; } = string.Empty;
    }
}
