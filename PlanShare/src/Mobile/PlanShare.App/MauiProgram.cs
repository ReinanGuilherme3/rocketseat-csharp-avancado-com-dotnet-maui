namespace PlanShare.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Raleway-Black.ttf", "RalewayBlack");
                fonts.AddFont("Raleway-Regular.ttf", "RalewayRegular");
                fonts.AddFont("Raleway-Thin.ttf", "RalewayThin");
                fonts.AddFont("WorkSans-Regular.ttf", "WorkSansRegular");
                fonts.AddFont("WorkSans-Bold.ttf", "WorkSansBold");
            });

        return builder.Build();
    }
}
