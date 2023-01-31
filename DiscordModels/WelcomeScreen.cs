using Newtonsoft.Json;
namespace DiscordAPIModels;
public class WelcomeScreen
{
    public string description { get; set; }
    public WelcomeScreenChannel[] welcome_channels { get; set; }
}