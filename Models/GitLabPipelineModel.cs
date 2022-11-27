using Newtonsoft.Json;

namespace beeWebHooksAPI.Models
{
    public class GitLabPipelineModel : RootobjectBaseModel
    {
        [JsonProperty("builds")]
        public Builds[]? Builds { get; set; }

        [JsonProperty("object_attributes")]
        public ObjectAttributesPipiline? ObjectAttributes { get; set; }
    }

    public class Builds
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("stage")]
        public string? Stage { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }
    }

    public class ObjectAttributesPipiline
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("detailed_status")]
        public string? DetailedStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }
    }
}