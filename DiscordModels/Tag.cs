using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Tag
{
    public ulong id { get; set; }
    public string? name { get; set; }
    public bool moderated { get; set; }
    public ulong? emoji_id { get; set; }
    public string? emoji_name { get; set; }
}