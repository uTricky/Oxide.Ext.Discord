namespace Oxide.Ext.Discord.DiscordObjects
{
    using System;
    using System.Collections.Generic;

    public class AllowedMentions
    {
        public List<string> parse { get; set; }

        public List<string> roles { get; set; }

        public List<string> users { get; set; }
    }
}
