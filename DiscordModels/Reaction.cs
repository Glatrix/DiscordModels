﻿using Newtonsoft.Json;
namespace DiscordAPIModels;
public class Reaction
{
    public int count { get; set; }
    public bool me { get; set; }
    public Emoji? emoji { get; set; }
}