using DiscordAPIModels;
using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Message
{
    public ulong id { get; set; }
    public ulong channel_id { get; set; }
    public User? author { get; set; }
    public string? content { get; set; }
    public DateTime timestamp { get; set; }
    public DateTime? edited_timestamp { get; set; }
    public bool tts { get; set; }
    public bool mention_everyone { get; set; }
    public Mention[]? mentions { get; set; }
    public Role[]? mention_roles { get; set; }
    public Attatchment[]? attachments { get; set; }
    public Embed[]? embeds { get; set; }
    public Reaction[]? reactions { get; set; }
    public string? nonce { get; set; }
    public bool pinned { get; set; }
    public ulong? webhook_id { get; set; }
    public int type { get; set; }
    public MessageActivity? activity { get; set; }
    public Application? application { get; set; }
    public ulong? application_id { get; set; }
    public MessageRef? message_reference { get; set; }
    public MessageFlags flags { get; set; }
    public Message? referenced_message { get; set; }
    public MessageInteraction? interaction { get; set; }
    public Channel? thread { get; set; }
    public MessageComponent[]? components { get; set; }
    public StickerItem[]? sticker_items { get; set; }
    public Sticker[]? stickers { get; set; }
    public int position { get; set; }
    public RoleSubscription? role_subscription_data { get; set; }
}