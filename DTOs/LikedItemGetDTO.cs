using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinder_app.DTOs
{
    public class LikedItemGetDTO
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("user_id")]
        public int UserID { get; set; }
    }
}
