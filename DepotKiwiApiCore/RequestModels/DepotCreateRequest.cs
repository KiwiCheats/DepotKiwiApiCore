using System.Text.Json.Serialization;

namespace DepotKiwiApiCore.RequestModels {
    public class DepotCreateRequest {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}