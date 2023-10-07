using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataApiService.Models
{
    public class CommandType
    {
        [JsonPropertyName("id")]
        public int Id {get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("parameter_name1")]
        public string ParamName1 { get; set; }

        [JsonPropertyName("parameter_name2")]
        public string ParamName2 { get; set; }

        [JsonPropertyName("parameter_name3")]
        public string ParamName3 { get; set; }

        // Note: Values are nullable in JSON, making them nullable int
        [JsonPropertyName("parameter_default_value1")]
        public int? ParamValue1 { get; set; }

        [JsonPropertyName("parameter_default_value2")]
        public int? ParamValue2 { get; set; }

        [JsonPropertyName("parameter_default_value3")]
        public int? ParamValue3 { get; set; }

    }
}
