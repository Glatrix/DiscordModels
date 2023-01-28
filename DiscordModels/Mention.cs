using DiscordAPIModels;

namespace DiscordAPIModels
{
    public class Mention
    {
        public ulong id;
        public ulong guild_id;
        public ChannelTypes type;
        public string? name;
    }
}