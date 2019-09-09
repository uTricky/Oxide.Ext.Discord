namespace Oxide.Ext.Discord.DiscordObjects
{
    using Newtonsoft.Json;

    public class Presence
    {
        [JsonProperty("status")]
        public string Status { get; set; } = "online";

        [JsonProperty("game")]
        public Game Game { get; set; }

        [JsonProperty("since")]
        public int? Since { get; set; }

        [JsonProperty("afk")]
        public bool AFK { get; set; }
    }
}
