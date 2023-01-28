using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Attatchment
{
    public ulong id;
    public string? filename;
    public string? description;
    public string? content_type;
    public int size;
    public string? url;
    public string? proxy_url;
    public int? height;
    public int? width;
    public bool? ephemeralt;
}