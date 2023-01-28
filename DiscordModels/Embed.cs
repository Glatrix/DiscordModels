using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json.Serialization;

namespace DiscordAPIModels;
public class Embed
{
    public string? title;
    public string? type;
    public string? description;
    public string? url;
    public DateTime? timestamp;
    public int color;
    public EmbedFooter? footer;
    public EmbedImage? image;
    public EmbedThumbnail? thumbnail;
    public EmbedVideo? video;
    public EmbedProvider? provider;
    public EmbedAuthor? author;
    public List<EmbedField>? fields;
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
    public string url;
    public string? proxy_url;
    public int? height;
    public int? width;
}

public class EmbedVideo
{
    public string? url;
    public string? proxy_url;
    public int? height;
    public int? width;
}

public class EmbedImage
{
    public string url;
    public string? proxy_url;
    public int? height;
    public int? width;
}

public class EmbedProvider
{
    public string name;
    public string? url;
    public string? icon_url;
    public string? proxy_icon_url;
}

public class EmbedAuthor
{
    public string name;
    public string? url;
    public string? icon_url;
    public string? proxy_icon_url;
}

public class EmbedFooter
{
    public string text;
    public string? icon_url;
    public string? proxy_icon_url;
}

public class EmbedField
{
    public string name;
    public string value;
    public bool? inline;
}
