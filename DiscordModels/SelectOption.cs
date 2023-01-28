using Newtonsoft.Json;

namespace DiscordAPIModels;

public class SelectOption
{
    public string? label { get; set; }
    public string? value { get; set; }
    public string? description { get; set; }
    public Emoji? emoji { get; set; }
    [JsonProperty("default")]
    public bool? isDefault { get; set;}

}