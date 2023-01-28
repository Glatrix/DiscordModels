namespace DiscordAPIModels;
[Flags]
public enum ChannelFlags
{
    PINNED = 1 << 1,
    REQUIRE_TAG = 1 << 4
}