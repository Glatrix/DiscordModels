using DiscordAPIModels;
using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Integration
{
    public ulong id;
    public string? name;
    public string? type;
    public bool? enabled;
    public bool? syncing;
    public ulong? role_id;
    public bool? enable_emoticons;
    public IntegrationExpireBehaviors? expire_behavior;
    public int? expire_grace_period;
    public User? user;
    public IntegrationAccount? account;
    public DateTime? synced_at;
    public int? subscriber_count;
    public bool? revoked;
    public IntegrationApplication? application;
}