using DiscordAPIModels;
using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Channel
{
    public ulong id;
    public ChannelTypes type;
    public ulong? guild_id;
    public int? position;
    public List<Overwrite>? permission_overwrites;
    public string? name;
    public string? topic;
    public bool? nsfw;
    public ulong? last_message_id;
    public int? bitrate;
    public int? user_limit;
    public int? rate_limit_per_user;
    public List<User>? recipients;
    public string? icon;
    public ulong? owner_id;
    public ulong? application_id;
    public ulong? parent_id;
    public DateTime? last_pin_timestamp;
    public string? rtc_region;
    public VideoQualityModes? video_quality_mode;
    public int? message_count;
    public int? member_count;
    public ThreadMetadata? thread_metadata;
    public ThreadMember? member;
    public int? default_auto_archive_duration;
    public string? permissions;
    public int? flags;
    public int? total_message_sent;
    public List<Tag>? available_tags;
    public List<ulong>? applied_tags;
    public DefaultReaction? default_reaction_emoji;
    public int? default_thread_rate_limit_per_user;
}