using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Role
{
    public ulong id;
    public string name;
    public int color;
    public bool hoist;
    public string? icon;
    public string? unicode_emoji;
    public int position;
    public string permissions;
    public bool managed;
    public bool mentionable;
    public RoleTags? tags;
}