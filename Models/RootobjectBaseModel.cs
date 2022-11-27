using Newtonsoft.Json;

namespace beeWebHooksAPI.Models
{
    public class RootobjectBaseModel
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("object_kind")]
        public string? ObjectKind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("user")]
        public User? User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("project")]
        public Project? Project { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("repository")]
        public Repository? Repository { get; set; }
    }

    public class User
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }
    }

    public class Project
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("web_url")]
        public string? WebUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("avatar_url")]
        public object? AvatarUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("git_ssh_url")]
        public string? GitSshUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("git_http_url")]
        public string? GitHttpUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("_namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("visibility_level")]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("path_with_namespace")]
        public string? PathWithNamespace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("default_branch")]
        public string? DefaultBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("ssh_url")]
        public string? SshUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("http_url")]
        public string? HttpUrl { get; set; }
    }

    public class Repository
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("homepage")]
        public string? Homepage { get; set; }
    }

    public class LastCommit
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("author")]
        public Author? Author { get; set; }
    }

    public class Author
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }
    }

    public class UpdatedById
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("previous")]
        public object? Previous { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("current")]
        public int? Current { get; set; }
    }

    public class UpdatedAt
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("previous")]
        public string? Previous { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("current")]
        public string? Current { get; set; }
    }
}