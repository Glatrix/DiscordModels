using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Emoji
{
    public ulong? id;
    public string? name;
    public List<ulong>? roles;
    public User? user;
    public bool? require_colons;
    public bool? managed;
    public bool? animated;
    public bool? available;
}