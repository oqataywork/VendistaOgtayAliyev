using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataApiService.Models
{
    public class TokenResponse
    {
        /// <summary>
        /// Строка токена
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }

        /// <summary>
        /// Идентификатор ??
        /// </summary>
        [JsonPropertyName("owner_id")]
        public int Owner_id { get; set; }

        /// <summary>
        /// Строка для случая ошибочной аутентификации
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
