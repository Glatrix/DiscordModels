using DiscordAPIModels;
using Newtonsoft.Json;
namespace DiscordAPIModels;
public class MessageInteraction
{
    public ulong? id;
    public InteractionTypes type;
    public string? name;
    public User? user;
    public GuildMember? member;
}