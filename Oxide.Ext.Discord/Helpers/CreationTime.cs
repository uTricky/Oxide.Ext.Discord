namespace Oxide.Ext.Discord.Helpers
{
    using Oxide.Ext.Discord.DiscordObjects;
    using System;

    public class CreationTime
    {
        public static DateTime? GetFromUser(User user) => GetFromID(user.id);

        public static DateTime? GetFromID(string ID)
        {
            long id = 0;
            long.TryParse(ID, out id);
            if (id == 0) return null;

            long ageInSeconds = ((id >> 22) + 1420070400000) / 1000;

            return new DateTime(2015, 1, 1).AddSeconds(ageInSeconds);
        }
    }
}
