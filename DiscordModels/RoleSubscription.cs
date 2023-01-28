using Newtonsoft.Json;
namespace DiscordAPIModels;
public class RoleSubscription
{
    public ulong? role_subscription_listing_id;
    public string? tier_name;
    public int? total_months_subscribed;
    public bool? is_renewal;
}