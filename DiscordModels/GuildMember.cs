using Newtonsoft.Json;
namespace DiscordAPIModels;
public class GuildMember
{
    public User? user;
    public string? nick;
    public string? avatar;
    public ulong[] roles;
    public DateTimeOffset joined_at;
    public DateTimeOffset? premium_since;
    public bool deaf;
    public bool mute;
    public bool? pending;
    public string? permissions;
    public DateTimeOffset? communication_disabled_until;
}