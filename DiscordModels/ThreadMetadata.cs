using Newtonsoft.Json;
namespace DiscordAPIModels;
public class ThreadMetadata
{
    public bool archived;
    public int auto_archive_duration;
    public DateTime archive_timestamp;
    public bool locked;
    public bool? invitable;
    public DateTime? create_timestamp;
}