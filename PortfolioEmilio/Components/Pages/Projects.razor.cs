using Microsoft.AspNetCore.Components;
using PortfolioEmilio.Components.Models;

namespace PortfolioEmilio.Components.Pages;

public partial class Projects : ComponentBase
{
    private List<ProjectModel> _projects = new()
    {
        new ProjectModel
        {
            Title = "Dream in Code Elderly Assistant",
            Description = "A voice-activated assistant built on Raspberry Pi, designed to support elderly users through wake-word detection and speech recognition. It leverages LLM technology to provide intelligent, context-aware assistance.",
            ImagePath = "images/DreamDeviceHD.jpg",
            Link = "https://github.com/ECF2001/Dream-Device"
        },
        
    };
}