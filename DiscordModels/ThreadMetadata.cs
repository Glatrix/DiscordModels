using Newtonsoft.Json;
namespace DiscordAPIModels;
public class ThreadMetadata
{
    public bool archived { get; set; }
    public int auto_archive_duration { get; set; }
    public DateTime archive_timestamp { get; set; }
    public bool locked { get; set; }
    public bool? invitable { get; set; }
    public DateTime? create_timestamp { get; set; }
}