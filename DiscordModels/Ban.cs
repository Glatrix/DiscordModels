using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Ban
{
    public string? reason { get; set; }
    public User user { get; set; }
}