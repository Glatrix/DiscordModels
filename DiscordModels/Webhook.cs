using DiscordAPIModels;
namespace DiscordAPIModels;

public class Webhook
{
    public ulong id { get; set; }
    public WebhookTypes type { get; set; }
    public string? guild_id { get; set; }
    public string? channel_id { get; set; }
    public User? user { get; set; }
    public string? name { get; set; }
    public string? avatar { get; set; }
    public string? token { get; set; }
    public ulong? application_id { get; set; }
    public Guild? source_guild { get; set; }
    public Channel? source_channel { get; set; }
    public string? url { get; set; }
}

public enum WebhookTypes
{
    Incoming = 1,
    Channel_Follower = 2,
    Application = 3,
}