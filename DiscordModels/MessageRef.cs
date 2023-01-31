using Newtonsoft.Json;
namespace DiscordAPIModels;
public class MessageRef
{
    public ulong? activity { get; set; }
    public ulong? channel_id { get; set; }
    public ulong? guild_id { get; set; }
    public bool? fail_if_not_exists { get; set; }
}