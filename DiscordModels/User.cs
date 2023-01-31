using Newtonsoft.Json;
namespace DiscordAPIModels;

public class User
{
    public ulong id { get; set; }
    public string username { get; set; }
    public string discriminator { get; set; }
    public string? avatar { get; set; }
    public bool? bot { get; set; }
    public bool? system { get; set; }
    public bool? mfa_enabled { get; set; }
    public string? banner { get; set; }
    public int? accent_color { get; set; }
    public string? locale { get; set; }
    public bool? verified { get; set; }
    public string? email { get; set; }
    public UserFlags flags { get; set; }
    public PremiumType premium_type { get; set; }
    public UserFlags public_flags { get; set; }
}