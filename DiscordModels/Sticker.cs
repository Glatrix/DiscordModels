using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Sticker
{
    public ulong id;
    public ulong? pack_id;
    public string name;
    public string? description;
    public string tags;
    public string? asset;
    public StickerType type;
    public StickerFormat format_type;
    public bool? available;
    public ulong? guild_id;
    public User? user;
    public int? sort_value;
}