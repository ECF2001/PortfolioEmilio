namespace PortfolioEmilio.Services.Helpers;

public class LangContent
{
    public string Label_Language { get; set; } = "Idioma";
    public string Home { get; set; } = "Inicio";
    public string Projects { get; set; } = "Proyectos";
    public string Services { get; set; } = "Servicios";
    public string Resume { get; set; } = "Currículum";
    public string Contact { get; set; } = "Contacto";

    public static LangContent Spanish => new()
    {
        Label_Language = "Idioma",
        Home = "Inicio",
        Projects = "Proyectos",
        Services = "Servicios",
        Resume = "Currículum",
        Contact = "Contacto"
    };

    public static LangContent English => new()
    {
        Label_Language = "Language",
        Home = "Home",
        Projects = "Projects",
        Services = "Services",
        Resume = "Resume",
        Contact = "Contact"
    };
}