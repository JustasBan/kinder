using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinder_app.DTOs
{
    public class GetListDTO<T>
    {
        [JsonProperty("data")]
        public IEnumerable<T> Data { get; set; }

        public GetListDTO(IEnumerable<T> data)
        {
            Data = data;
        }
    }
}
