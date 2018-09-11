using LetsRaid.Models.ServerModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LetsRaid.Models.GuildModels
{
    public class Guild
    {
        public int GuildId { get; set; }
        public string Name { get; set; }
        public virtual Server Server { get; set; }
        public int ServerId { get; set; }
       
        [JsonProperty("members")]
        public List<GuildMember> Members { get; set; }
    }
}