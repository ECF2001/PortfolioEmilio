using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PortfolioEmilio.Components.Models;

namespace PortfolioEmilio.Components.Pages;

public partial class Contact : ComponentBase
{
    private ContactModel contactModel = new();
    private bool successMessageVisible = false;
    
    private string LinkedInLink = "https://www.linkedin.com/in/emilio-conejo-a56783234";
    private string GitHubLink = "https://github.com/ECF2001";

    [Inject] IJSRuntime JS { get; set; }

    private async Task OpenUrl(string url)
    {
        await JS.InvokeVoidAsync("open", url, "_blank");
    }
    
    private void HandleValidSubmit()
    {
        successMessageVisible = true;
        contactModel = new ContactModel();
    }

    private IEnumerable<string> ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            yield return "Email is required";

        else if (!System.Text.RegularExpressions.Regex.IsMatch(email,
                     @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            yield return "Invalid email format";
    }
}