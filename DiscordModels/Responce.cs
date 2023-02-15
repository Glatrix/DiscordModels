using DiscordAPIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiscordModels
{
    public class Response
    {
        public ResponseType type { get; set; }
        public ResponseData? data { get; set; }
    }
    public class ResponseData
    {
        public bool tts { get; set; }
        public string? content { get; set; }
        public List<Embed>? embeds { get; set; }
        public MessageFlags? flags { get; set; }
        public List<Attatchment>? attachments { get; set; }
    }
}
