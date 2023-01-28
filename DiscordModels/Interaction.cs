using DiscordAPIModels;
using Newtonsoft.Json;
namespace DiscordAPIModels;

public class Interaction
{
    public UInt64 id { get; set; }
    public UInt64 application_id { get; set; }
    public InteractionTypes type { get; set; }
    public InteractionData? data { get; set; }
    public UInt64? guild_id { get; set; }
    public UInt64? channel_id { get; set; }
    public GuildMember? member { get; set; }
    public User? user { get; set; }
    public string? token { get; set; }
    public int version { get; set; }
    public Message? message { get; set; }
    public string? app_permissions { get; set; }
    public string? locale { get; set; }
    public string? guild_locale { get; set; }
}