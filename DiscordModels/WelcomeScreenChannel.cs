using Newtonsoft.Json;
namespace DiscordAPIModels;
public class WelcomeScreenChannel
{
    public string? channel_id { get; set; }
    public string? description { get; set; }
    public string? emoji_id{ get; set; }
    public string? emoji_name{ get; set; }
}