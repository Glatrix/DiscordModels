using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Tag
{
    public ulong id;
    public string? name;
    public bool moderated;
    public ulong? emoji_id;
    public string? emoji_name;
}