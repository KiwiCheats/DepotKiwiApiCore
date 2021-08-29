using System.Text.Json.Serialization;

namespace DepotKiwiApiCore.Models {
    public class FileInfo {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("sha256")]
        public string Sha256 { get; set; }
    }
}