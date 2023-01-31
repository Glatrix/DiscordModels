using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json.Serialization;

namespace DiscordAPIModels;
public class Embed
{
    public string? title { get; set; }
    public string? type { get; set; }
    public string? description { get; set; }
    public string? url { get; set; }
    public DateTime? timestamp { get; set; }
    public int color { get; set; }
    public EmbedFooter? footer { get; set; }
    public EmbedImage? image { get; set; }
    public EmbedThumbnail? thumbnail { get; set; }
    public EmbedVideo? video { get; set; }
    public EmbedProvider? provider { get; set; }
    public EmbedAuthor? author { get; set; }
    public List<EmbedField>? fields { get; set; }
}

public enum EmbedTypes
{
    rich,
    image,
    video,
    gifv,
    article,
    link,
}

public class EmbedThumbnail
{
    public string url { get; set; }
    public string? proxy_url { get; set; }
    public int? height { get; set; }
    public int? width { get; set; }
}

public class EmbedVideo
{
    public string? url { get; set; }
    public string? proxy_url { get; set; }
    public int? height { get; set; }
    public int? width { get; set; }
}

public class EmbedImage
{
    public string url { get; set; }
    public string? proxy_url { get; set; }
    public int? height { get; set; }
    public int? width { get; set; }
}

public class EmbedProvider
{
    public string name { get; set; }
    public string? url { get; set; }
    public string? icon_url { get; set; }
    public string? proxy_icon_url { get; set; }
}

public class EmbedAuthor
{
    public string name { get; set; }
    public string? url { get; set; }
    public string? icon_url { get; set; }
    public string? proxy_icon_url { get; set; }
}

public class EmbedFooter
{
    public string text { get; set; }
    public string? icon_url { get; set; }
    public string? proxy_icon_url { get; set; }
}

public class EmbedField
{
    public string name { get; set; }
    public string value { get; set; }
    public bool? inline { get; set; }
}
