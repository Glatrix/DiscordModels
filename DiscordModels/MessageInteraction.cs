using DiscordAPIModels;
using Newtonsoft.Json;
namespace DiscordAPIModels;
public class MessageInteraction
{
    public ulong? id { get; set; }
    public InteractionTypes type { get; set; }
    public string? name { get; set; }
    public User? user { get; set; }
    public GuildMember? member { get; set; }
}