using DiscordAPIModels;

namespace DiscordAPIModels;

public class MessageComponent
{
    public string? custom_id { get; set; }
    public ComponentTypes component_type { get; set; }
    SelectOption[]? values { get; set; }
}
