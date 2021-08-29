using System.Text.Json.Serialization;

namespace DepotKiwiApiCore.RequestModels {
    public class DepotDeleteRequest {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}