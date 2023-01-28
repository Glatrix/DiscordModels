using DiscordAPIModels;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace DiscordAPIModels;

internal class Command
{
    public ulong id;
    public CommandTypes? type;
    public ulong application_id;
    public ulong? guild_id;
    public string? name;
    public Dictionary<string, string>? name_localizations;
    public string? description;
    public Dictionary<string, string>? description_localizations;
    public List<CommandOption>? options;
    public string? default_member_permissions;
    public bool? dm_permission;
    public bool? default_permission;
    public bool? nsfw;
    public ulong version;
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
    public CommandOptionTypes type;
    public string? name;
    public Dictionary<string, string>? name_localizations;
    public string? description;
    public Dictionary<string, string>? description_localizations;
    public bool? required;
    public List<CommandOptionChoice>? choices;
    public List<CommandOption>? options;
    public List<ChannelTypes>? channel_types;
    public int? min_value;
    public int? max_value;
    public int? min_length;
    public int? max_length;
    public bool? autocomplete;
}

public class CommandOptionChoice
{
    public string? name;
    public Dictionary<string, string>? name_localizations;

    /// <summary>
    /// string, integer, or double
    /// </summary>
    public object? value;
}