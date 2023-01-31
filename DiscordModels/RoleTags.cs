using Newtonsoft.Json;
namespace DiscordAPIModels;
public class RoleTags
{
    public ulong? bot_id { get; set; }
    public ulong? integration_id { get; set; }
    public bool? premium_subscriber { get; set; }
}