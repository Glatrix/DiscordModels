using DiscordAPIModels;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace DiscordAPIModels;

internal class Command
{
    public ulong id { get; set; }
    public CommandTypes? type { get; set; }
    public ulong application_id { get; set; }
    public ulong? guild_id { get; set; }
    public string? name { get; set; }
    public Dictionary<string, string>? name_localizations { get; set; }
    public string? description { get; set; }
    public Dictionary<string, string>? description_localizations { get; set; }
    public List<CommandOption>? options { get; set; }
    public string? default_member_permissions { get; set; }
    public bool? dm_permission { get; set; }
    public bool? default_permission { get; set; }
    public bool? nsfw { get; set; }
    public ulong version { get; set; }
}


public enum CommandOptionTypes
{
    SUB_COMMAND = 1,
    SUB_COMMAND_GROUP = 2,
    STRING = 3,
    INTEGER = 4,
    BOOLEAN = 5,
    USER = 6,
    CHANNEL = 7,
    ROLE = 8,
    MENTIONABLE = 9,
    NUMBER = 10,
    ATTACHMENT = 11
}

public class CommandOption
{
    public CommandOptionTypes type { get; set; }
    public string? name { get; set; }
    public Dictionary<string, string>? name_localizations { get; set; }
    public string? description { get; set; }
    public Dictionary<string, string>? description_localizations { get; set; }
    public bool? required { get; set; }
    public List<CommandOptionChoice>? choices { get; set; }
    public List<CommandOption>? options { get; set; }
    public List<ChannelTypes>? channel_types { get; set; }
    public int? min_value { get; set; }
    public int? max_value { get; set; }
    public int? min_length { get; set; }
    public int? max_length { get; set; }
    public bool? autocomplete { get; set; }
}

public class CommandOptionChoice
{
    public string? name { get; set; }
    public Dictionary<string, string>? name_localizations { get; set; }

    /// <summary>
    /// string, integer, or double
    /// </summary>
    public object? value { get; set; }
}