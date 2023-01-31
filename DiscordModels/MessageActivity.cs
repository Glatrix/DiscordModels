using Newtonsoft.Json;
namespace DiscordAPIModels;
public class MessageActivity
{
    public int type { get; set; }
    public string party_id { get; set; }
}