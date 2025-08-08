using Microsoft.AspNetCore.Components;
using PortfolioEmilio.Components.Models;

namespace PortfolioEmilio.Components.Pages;

public partial class Contact : ComponentBase
{
    private ContactModel contactModel = new();
    private bool successMessageVisible = false;

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