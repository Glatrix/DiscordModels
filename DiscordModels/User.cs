using Newtonsoft.Json;
namespace DiscordAPIModels;

public class User
{
    public ulong id;
    public string username;
    public string discriminator;
    public string? avatar;
    public bool? bot;
    public bool? system;
    public bool? mfa_enabled;
    public string? banner;
    public int? accent_color;
    public string? locale;
    public bool? verified;
    public string? email;
    public UserFlags flags;
    public PremiumType premium_type;
    public UserFlags public_flags;
}