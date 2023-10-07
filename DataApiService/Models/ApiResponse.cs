using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataApiService.Models
{
    public class ApiResponse
    {
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        [JsonPropertyName("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonPropertyName("items_count")]
        public int ItemsCount { get; set; }

        [JsonPropertyName("items")]
        public IEnumerable<CommandType> Items { get; set; }
    }
}
