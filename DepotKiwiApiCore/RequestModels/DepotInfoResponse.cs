using System.Text.Json.Serialization;
using DepotKiwiApiCore.Models;

namespace DepotKiwiApiCore.RequestModels {
    public class DepotInfoResponse {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        
        [JsonPropertyName("depot")]
        public Depot Depot { get; set; }
    }
}