using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Sticker
{
    public ulong id { get; set; }
    public ulong? pack_id { get; set; }
    public string name { get; set; }
    public string? description { get; set; }
    public string tags { get; set; }
    public string? asset { get; set; }
    public StickerType type { get; set; }
    public StickerFormat format_type { get; set; }
    public bool? available { get; set; }
    public ulong? guild_id { get; set; }
    public User? user { get; set; }
    public int? sort_value { get; set; }
}