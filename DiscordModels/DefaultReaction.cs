using Newtonsoft.Json;
namespace DiscordAPIModels;
public class DefaultReaction
{
    public ulong? emoji_id { get; set; }
    public string? emoji_name { get; set; }
}