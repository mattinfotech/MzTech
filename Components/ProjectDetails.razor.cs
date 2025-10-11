using Microsoft.AspNetCore.Components;

namespace MzTech.Components
{
    public partial class ProjectDetails
    {
        [Parameter] public string? Title { get; set; }
        [Parameter] public string? Subtitle { get; set; }
        [Parameter] public string? MainImage { get; set; }
        [Parameter] public string? AboutDescription { get; set; }
        [Parameter] public string? AdditionalDescription { get; set; }
        [Parameter] public List<string>? Features { get; set; }
        [Parameter] public string? TechStack { get; set; }
        [Parameter] public string? ContactUrl { get; set; }
        [Parameter] public List<string>? AdditionalImages { get; set; }
    }
}
