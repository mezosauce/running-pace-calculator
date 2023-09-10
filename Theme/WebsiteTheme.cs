using MudBlazor;

namespace running_pace_calculator.Theme;
public class WebsiteTheme : MudTheme
{
    public WebsiteTheme()
    {
        Palette = new PaletteLight()
        {
            Primary = "#f90c0c",
            Secondary = "#9E9E9E",
            Tertiary = "#e6e6e6",
            TertiaryContrastText = "#000",
            Background = "#eee",
            Surface = "#f5f3f4",
            AppbarBackground = "#353535",
            AppbarText = "rgba(255,255, 255, 0.7)",
            DrawerBackground = "#f5f3f4",
            DrawerText = "rgba(0, 0, 0, 0.9)",
            Success = "#06d79c",
            Divider = "#000000cc",
            DividerLight = "#e0e0e0ff",
            White = "#ffffff",
            TextDisabled = "#777777",
            ErrorLighten = "ffe6e6",
            SuccessLighten = "eaffe6",
        };

        PaletteDark = new PaletteDark()
        {
            Primary = "#2e9884",
            PrimaryContrastText = "f5f5dc",
            Secondary = "#408ec6",
            Tertiary = "#424242",
            TertiaryContrastText = "#fff",
            Black = "#171717",
            Background = "#1e1e2d",
            BackgroundGrey = "#0e0e0e",
            Surface = "rgba(37,37,37, 1.0)",
            DrawerBackground = "rgba(14,14,14, 1.0)",
            DrawerText = "rgba(255,255,255, 0.50)",
            DrawerIcon = "rgba(255,255,255, 0.50)",
            AppbarBackground = "rgba(28,28,28, 1.0)",
            AppbarText = "rgba(255,255,255, 0.70)",
            TextPrimary = "f5f5dc",
            TextSecondary = "rgba(255,255,255, 0.50)",
            ActionDefault = "#adadb1",
            ActionDisabled = "rgba(255,255,255, 0.26)",
            ActionDisabledBackground = "rgba(255,255,255, 0.12)",
            Divider = "rgba(255,255,255, 0.12)",
            DividerLight = "rgba(255,255,255, 0.06)",
            TableLines = "rgba(255,255,255, 0.12)",
            LinesDefault = "rgba(255,255,255, 0.12)",
            LinesInputs = "rgba(255,255,255, 0.3)",
            TextDisabled = "rgba(255,255,255, 0.2)",
            White = "ffffff",
            ErrorLighten = "660000",
            SuccessLighten = "004D00"
        };

        Typography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "", "Ubuntu", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
        };
    }
}

