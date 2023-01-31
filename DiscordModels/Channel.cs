using DiscordAPIModels;
using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Channel
{
    public ulong id { get; set; }
    public ChannelTypes type { get; set; }
    public ulong? guild_id { get; set; }
    public int? position { get; set; }
    public List<Overwrite>? permission_overwrites { get; set; }
    public string? name { get; set; }
    public string? topic { get; set; }
    public bool? nsfw { get; set; }
    public ulong? last_message_id { get; set; }
    public int? bitrate { get; set; }
    public int? user_limit { get; set; }
    public int? rate_limit_per_user { get; set; }
    public List<User>? recipients { get; set; }
    public string? icon { get; set; }
    public ulong? owner_id { get; set; }
    public ulong? application_id { get; set; }
    public ulong? parent_id { get; set; }
    public DateTime? last_pin_timestamp { get; set; }
    public string? rtc_region { get; set; }
    public VideoQualityModes? video_quality_mode { get; set; }
    public int? message_count { get; set; }
    public int? member_count { get; set; }
    public ThreadMetadata? thread_metadata { get; set; }
    public ThreadMember? member { get; set; }
    public int? default_auto_archive_duration { get; set; }
    public string? permissions { get; set; }
    public int? flags { get; set; }
    public int? total_message_sent { get; set; }
    public List<Tag>? available_tags { get; set; }
    public List<ulong>? applied_tags { get; set; }
    public DefaultReaction? default_reaction_emoji { get; set; }
    public int? default_thread_rate_limit_per_user { get; set; }
}