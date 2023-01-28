using Newtonsoft.Json;
namespace DiscordAPIModels;
public class WelcomeScreen
{
    public string description;
    public WelcomeScreenChannel[] welcome_channels;
}