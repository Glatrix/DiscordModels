using DiscordAPIModels;
using Newtonsoft.Json;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace DiscordAPIModels;

public class InteractionData
{
    public UInt64? id { get; set; }
    public string? name { get; set; }
    public CommandTypes? type { get; set; }
    public ResolvedData? resolved { get; set; }
    public List<InteractionOption>? options { get; set; }
    public UInt64? guild_id { get; set; }
    public UInt64? target_id { get; set; }
}

public class InteractionOption
{
    public string? name { get; set; }
    public int type { get; set; }
    public object? value { get; set; }
    public List<CommandOption>? options { get; set; }
    public bool? focused { get; set; }
}
