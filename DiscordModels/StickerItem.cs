using Newtonsoft.Json;
namespace DiscordAPIModels;
public class StickerItem
{
    public int id { get; set; }
    public string? name { get; set; }
    public StickerFormat format_type { get; set; }
}