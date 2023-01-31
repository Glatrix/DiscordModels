using Newtonsoft.Json;
namespace DiscordAPIModels;
public class ThreadMember
{
    public ulong? id { get; set; }
    public ulong? user_id { get; set; }
    public DateTime join_timestamp { get; set; }
    public int flags { get; set; }
}