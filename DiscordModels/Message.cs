using DiscordAPIModels;
using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Message
{
    public ulong id;
    public ulong channel_id;
    public User? author;
    public string? content;
    public DateTime timestamp;
    public DateTime? edited_timestamp;
    public bool tts;
    public bool mention_everyone;
    public Mention[]? mentions;
    public Role[]? mention_roles;
    public Attatchment[]? attachments;
    public Embed[]? embeds;
    public Reaction[]? reactions;
    public string? nonce;
    public bool pinned;
    public ulong? webhook_id;
    public int type;
    public MessageActivity? activity;
    public Application? application;
    public ulong? application_id;
    public MessageRef? message_reference;
    public MessageFlags flags;
    public Message? referenced_message;
    public MessageInteraction? interaction;
    public Channel? thread;
    public MessageComponent[]? components;
    public StickerItem[]? sticker_items;
    public Sticker[]? stickers;
    public int position;
    public RoleSubscription? role_subscription_data;
}