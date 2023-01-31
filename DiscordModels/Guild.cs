using DiscordAPIModels;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DiscordAPIModels;
public class Guild
{
    public ulong id { get; set; }
    public string? name { get; set; }
    public string? icon { get; set; }
    public string? icon_hash { get; set; }
    public string? splash { get; set; }
    public string? discovery_splash { get; set; }
    public bool? owner { get; set; }
    public ulong owner_id { get; set; }
    public string? permissions { get; set; }
    public string? region { get; set; }
    public ulong? afk_channel_id { get; set; }
    public int afk_timeout { get; set; }
    public bool? widget_enabled { get; set; }
    public ulong? widget_channel_id { get; set; }
    public VerificationLevel verification_level { get; set; }
    public DefaultMessageNotificationLevel default_message_notifications { get; set; }
    public ExplicitContentFilterLevel explicit_content_filter { get; set; }
    public List<Role>? roles { get; set; }
    public List<Emoji>? emojis { get; set; }
    public List<GuildFeatures>? features { get; set; }
    public MFALevel mfa_level { get; set; }
    public ulong? application_id { get; set; }
    public ulong? system_channel_id { get; set; }
    public SystemChannelFlags system_channel_flags { get; set; }
    public ulong? rules_channel_id { get; set; }
    public int? max_presences { get; set; }
    public int? max_members { get; set; }
    public string? vanity_url_code { get; set; }
    public string? description { get; set; }
    public string? banner { get; set; }
    public PremiumTier premium_tier { get; set; }
    public int? premium_subscription_count { get; set; }
    public string? preferred_locale { get; set; }
    public ulong? public_updates_channel_id { get; set; }
    public int? max_video_channel_users { get; set; }
    public int? approximate_member_count { get; set; }
    public int? approximate_presence_count { get; set; }
    public WelcomeScreen? welcome_screen { get; set; }
    public int nsfw_level { get; set; }
    public List<Sticker>? stickers { get; set; }
    public bool? premium_progress_bar_enabled { get; set; }
}