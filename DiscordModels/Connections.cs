using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Connections
{
    public string id { get; set; }
    public string name { get; set; }
    public string type { get; set; }
    public bool? revoked { get; set; }
}