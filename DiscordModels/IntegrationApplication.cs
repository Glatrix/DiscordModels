using Newtonsoft.Json;
namespace DiscordAPIModels;
public class IntegrationApplication
{
    public ulong id { get; set; }
    public string name { get; set; }
    public string? icon { get; set; }
    public string description { get; set; }
    public User? bot { get; set; }
}