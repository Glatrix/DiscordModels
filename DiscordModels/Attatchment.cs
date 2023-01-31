using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Attatchment
{
    public ulong id { get; set; }
    public string? filename { get; set; }
    public string? description { get; set; }
    public string? content_type { get; set; }
    public int size { get; set; }
    public string? url { get; set; }
    public string? proxy_url { get; set; }
    public int? height { get; set; }
    public int? width { get; set; }
    public bool? ephemeralt { get; set; }
}