using LilyLandBlazorSite.Services;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace LilyLandBlazorSite.Portfolio.Pages
{
	public class PortfolioBase : ComponentBase
	{
		[Inject] public PaletteService PaletteService { get; set; } = default!;

		protected override async Task OnInitializedAsync()
		{
			await PaletteService.SetPalette("default");
		}
	}
}
