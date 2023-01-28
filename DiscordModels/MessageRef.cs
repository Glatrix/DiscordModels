using Newtonsoft.Json;
namespace DiscordAPIModels;
public class MessageRef
{
    public ulong? activity;
    public ulong? channel_id;
    public ulong? guild_id;
    public bool? fail_if_not_exists;
}