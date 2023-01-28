using Newtonsoft.Json;
namespace DiscordAPIModels;
public class IntegrationApplication
{
    public ulong id;
    public string name;
    public string? icon;
    public string description;
    public User? bot;
}