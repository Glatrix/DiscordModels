using Newtonsoft.Json;
namespace DiscordAPIModels;
public class ThreadMember
{
    public ulong? id;
    public ulong? user_id;
    public DateTime join_timestamp;
    public int flags;
}