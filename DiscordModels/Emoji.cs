using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Emoji
{
    public ulong? id { get; set; }
    public string? name { get; set; }
    public List<ulong>? roles { get; set; }
    public User? user { get; set; }
    public bool? require_colons { get; set; }
    public bool? managed { get; set; }
    public bool? animated { get; set; }
    public bool? available { get; set; }
}