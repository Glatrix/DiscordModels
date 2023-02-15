using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordAPIModels
{

    [Flags]
    public enum ResponseType
    {
        PONG = 1,
        CHANNEL_MESSAGE_WITH_SOURCE = 4,
        DEFERRED_CHANNEL_MESSAGE_WITH_SOURCE = 5,
        DEFERRED_UPDATE_MESSAGE = 6,
        UPDATE_MESSAGE = 7,
        APPLICATION_COMMAND_AUTOCOMPLETE_RESULT = 8,
        MODAL = 9,
    }
}
