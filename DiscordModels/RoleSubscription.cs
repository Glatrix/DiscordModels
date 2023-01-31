using Newtonsoft.Json;
namespace DiscordAPIModels;
public class RoleSubscription
{
    public ulong? role_subscription_listing_id { get; set; }
    public string? tier_name { get; set; }
    public int? total_months_subscribed { get; set; }
    public bool? is_renewal { get; set; }
}