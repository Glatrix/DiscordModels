namespace DiscordAPIModels;

public class Application
{
    public ulong id;
    public string? name;
    public string? icon;
    public string? description;
    public List<string>? rpc_origins;
    public bool bot_public;
    public bool bot_require_code_grant;
    public string? terms_of_service_url;
    public string? privacy_policy_url;
    public User? owner;
    [Obsolete("marked as obsolete in discord docs")]
    public string? summary;
    public string? verify_key;
    public Team? team;
    public ulong? guild_id;
    public ulong? primary_sku_id;
    public string? slug;
    public string? cover_image;
    public ApplicationFlags flags;
    public List<string>? tags;
    public InstallParams? install_params;
    public string? custom_install_url;
    public string? role_connections_verification_url;
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
    public List<string>? scopes;
    public string? permissions;
}