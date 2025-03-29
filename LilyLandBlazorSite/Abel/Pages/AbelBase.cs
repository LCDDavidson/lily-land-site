using LilyLandBlazorSite.Services;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
namespace LilyLandBlazorSite.Abel.Pages
{
	public class AbelBase : ComponentBase
	{
		[Inject] public PaletteService PaletteService { get; set; } = default!;

		protected override async Task OnInitializedAsync()
		{
			await PaletteService.SetPalette("Abel");
		}
	}
}
