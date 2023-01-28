namespace DiscordAPIModels;

public class Team
{
    public string? icon;
    public ulong id;
    public List<TeamMember> members;
    public string name;
    public ulong owner_user_id;
}

public class TeamMember
{
    public MembershipState membership_state;
    public List<string> permissions;
    public ulong team_id;
    public User user;
}


public enum MembershipState
{
    INVITED = 1,
    ACCEPTED = 2
}
