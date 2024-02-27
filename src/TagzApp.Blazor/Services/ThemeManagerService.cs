using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace TagzApp.Blazor.Services;

public class ThemeManagerService
{
	private readonly IConfiguration _Configuration;

	public string CurrentTheme { get; private set; } = "light";

	public ThemeManagerService(IConfiguration configuration)
	{
		_Configuration = configuration;
	}

	public void ToggleTheme()
	{
		CurrentTheme = CurrentTheme == "light" ? "dark" : "light";
	}

}
