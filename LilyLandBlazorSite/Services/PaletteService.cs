using Microsoft.JSInterop;
using System.Reflection;

namespace LilyLandBlazorSite.Services
{
    public class PaletteService(IJSRuntime jsRuntime)
	{
		private readonly IJSRuntime _jsRuntime = jsRuntime;

		public async Task SetPalette(string palette)
		{
			await _jsRuntime.InvokeVoidAsync("setPalette", palette.ToLower());
		}
	}
}
