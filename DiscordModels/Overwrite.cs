using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Overwrite
{
    public ulong id { get; set; }
    public string type { get; set; }
    public string allow { get; set; }
    public string deny { get; set; }
}