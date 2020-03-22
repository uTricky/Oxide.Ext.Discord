namespace Oxide.Ext.Discord.DiscordObjects
{
    using System;
    using Oxide.Ext.Discord.REST;

    public class InviteDeleted
    {
        public string channel_id { get; set; }

        public string guild_id { get; set; }

        public string code { get; set; }
    }
}
