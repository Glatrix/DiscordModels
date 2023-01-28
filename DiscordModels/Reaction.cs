using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Reaction
{
    public int count;
    public bool me;
    public Emoji? emoji;
}