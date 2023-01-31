namespace DiscordAPIModels;

public class Application
{
    public ulong id { get; set; }
    public string? name { get; set; }
    public string? icon { get; set; }
    public string? description { get; set; }
    public List<string>? rpc_origins { get; set; }
    public bool bot_public { get; set; }
    public bool bot_require_code_grant { get; set; }
    public string? terms_of_service_url { get; set; }
    public string? privacy_policy_url { get; set; }
    public User? owner { get; set; }
    [Obsolete("marked as obsolete in discord docs")]
    public string? summary { get; set; }
    public string? verify_key { get; set; }
    public Team? team { get; set; }
    public ulong? guild_id { get; set; }
    public ulong? primary_sku_id { get; set; }
    public string? slug { get; set; }
    public string? cover_image { get; set; }
    public ApplicationFlags flags { get; set; }
    public List<string>? tags { get; set; }
    public InstallParams? install_params { get; set; }
    public string? custom_install_url { get; set; }
    public string? role_connections_verification_url { get; set; }
}

[Flags]
public enum ApplicationFlags
{
    GATEWAY_PRESENCE = 1 << 12,
    GATEWAY_PRESENCE_LIMITED = 1 << 13,
    GATEWAY_GUILD_MEMBERS = 1 << 14,
    GATEWAY_GUILD_MEMBERS_LIMITED = 1 << 15,
    VERIFICATION_PENDING_GUILD_LIMIT = 1 << 16,
    EMBEDDED = 1 << 17,
    GATEWAY_MESSAGE_CONTENT = 1 << 18,
    GATEWAY_MESSAGE_CONTENT_LIMITED = 1 << 19,
    APPLICATION_COMMAND_BADGE = 1 << 23,
}


public class InstallParams
{
    public List<string>? scopes { get; set; }
    public string? permissions { get; set; }
}