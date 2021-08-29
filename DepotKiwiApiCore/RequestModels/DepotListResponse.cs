using System.Text.Json.Serialization;

namespace DepotKiwiApiCore.RequestModels {
    public class DepotListResponse {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}