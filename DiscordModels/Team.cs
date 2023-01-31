namespace DiscordAPIModels;

public class Team
{
    public string? icon { get; set; }
    public ulong id { get; set; }
    public List<TeamMember> members { get; set; }
    public string name { get; set; }
    public ulong owner_user_id { get; set; }
}

public class TeamMember
{
    public MembershipState membership_state { get; set; }
    public List<string> permissions { get; set; }
    public ulong team_id { get; set; }
    public User user { get; set; }
}


public enum MembershipState
{
    INVITED = 1,
    ACCEPTED = 2
}
