using DiscordAPIModels;
using Newtonsoft.Json;


namespace DiscordAPIModels;

public class InteractionData
{
    public UInt64? id { get; set; }
    public string? name { get; set; }
    public CommandTypes? type { get; set; }
    public ResolvedData? resolved { get; set; }
    public object[]? options { get; set; }
    public UInt64? guild_id { get; set; }
    public UInt64? target_id { get; set; }
    public string? custom_id { get; set; }
    public ComponentTypes? component_type { get; set; }
    public SelectOption[]? values { get; set; }
    public MessageComponent[]? components { get; set; }
}