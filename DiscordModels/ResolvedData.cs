using System.Dynamic;

namespace DiscordAPIModels;

public class ResolvedData
{
    public User[]? users { get; set; }
    public GuildMember[]? members { get; set; }
    public Role[]? roles { get; set; }
    public Channel[]? channels { get; set; }
    public Message[]? messages { get; set; }
    public Attatchment[]? attatchments { get; set; }
}