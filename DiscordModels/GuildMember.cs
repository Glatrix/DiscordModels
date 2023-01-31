using Newtonsoft.Json;
namespace DiscordAPIModels;
public class GuildMember
{
    public User? user { get; set; }
    public string? nick { get; set; }
    public string? avatar { get; set; }
    public ulong[] roles { get; set; }
    public DateTimeOffset joined_at { get; set; }
    public DateTimeOffset? premium_since { get; set; }
    public bool deaf { get; set; }
    public bool mute { get; set; }
    public bool? pending { get; set; }
    public string? permissions { get; set; }
    public DateTimeOffset? communication_disabled_until { get; set; }
}