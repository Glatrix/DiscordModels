using DiscordAPIModels;

namespace DiscordAPIModels
{
    public class Mention
    {
        public ulong id { get; set; }
        public ulong guild_id { get; set; }
        public ChannelTypes type { get; set; }
        public string? name { get; set; }
    }
}