using PortfolioEmilio.Services.Helpers;

namespace PortfolioEmilio.Services;

public class LanguageService
{
    public string CurrentLanguage { get; private set; } = "es";
    public LangContent Content { get; private set; } = LangContent.Spanish;

    public event Action? OnLanguageChanged;

    public void SetLanguage(string lang)
    {
        CurrentLanguage = lang;
        Content = lang switch
        {
            "en" => LangContent.English,
            _ => LangContent.Spanish
        };
        OnLanguageChanged?.Invoke();
    }
}