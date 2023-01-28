using DiscordAPIModels;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DiscordAPIModels;
public class Guild
{
    public ulong id;
    public string? name;
    public string? icon;
    public string? icon_hash;
    public string? splash;
    public string? discovery_splash;
    public bool? owner;
    public ulong owner_id;
    public string? permissions;
    public string? region;
    public ulong? afk_channel_id;
    public int afk_timeout;
    public bool? widget_enabled;
    public ulong? widget_channel_id;
    public VerificationLevel verification_level;
    public DefaultMessageNotificationLevel default_message_notifications;
    public ExplicitContentFilterLevel explicit_content_filter;
    public List<Role>? roles;
    public List<Emoji>? emojis;
    public List<GuildFeatures>? features;
    public MFALevel mfa_level;
    public ulong? application_id;
    public ulong? system_channel_id;
    public SystemChannelFlags system_channel_flags;
    public ulong? rules_channel_id;
    public int? max_presences;
    public int? max_members;
    public string? vanity_url_code;
    public string? description;
    public string? banner;
    public PremiumTier premium_tier;
    public int? premium_subscription_count;
    public string? preferred_locale;
    public ulong? public_updates_channel_id;
    public int? max_video_channel_users;
    public int? approximate_member_count;
    public int? approximate_presence_count;
    public WelcomeScreen? welcome_screen;
    public int nsfw_level;
    public List<Sticker>? stickers;
    public bool? premium_progress_bar_enabled;
}