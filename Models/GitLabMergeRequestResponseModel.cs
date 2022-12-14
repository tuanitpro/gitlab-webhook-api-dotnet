using Newtonsoft.Json;

namespace beeWebHooksAPI.Models
{
    public class GitLabMergeRequestResponseModel
    {
        public MergeRequestProperty? CommonProperty { get; set; }

        public Rootobject? RawProperty { set; get; }

        public class MergeRequestProperty
        {
            public MergeRequestProperty(string sourceGitSshUrl, string sourceBranch, string lastCommitId,
                string targetGitSshUrl, string targetBranch, string title, string username, string mergeRequestUrl)
            {
                SourceGitSshUrl = sourceGitSshUrl;
                SourceBranch = sourceBranch;
                LastCommitId = lastCommitId;
                TargetGitSshUrl = targetGitSshUrl;
                TargetBranch = targetBranch;
                Title = title;
                Username = username;
                MergeRequestUrl = mergeRequestUrl;
            }

            public string SourceGitSshUrl { get; }
            public string SourceBranch { get; }
            public string LastCommitId { get; }
            public string TargetGitSshUrl { get; }
            public string TargetBranch { get; }
            public string Title { get; }
            public string Username { get; }
            public string MergeRequestUrl { get; }
        }

        public class Rootobject : RootobjectBaseModel
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty("object_attributes")]
            public ObjectAttributes? ObjectAttributes { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("labels")]
            public Label[]? Labels { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("changes")]
            public Changes? Changes { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("assignees")]
            public Assignee[]? Assignees { get; set; }
        }

        public class ObjectAttributes
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty("id")]
            public int? Id { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("target_branch")]
            public string? TargetBranch { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("source_branch")]
            public string? SourceBranch { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("source_project_id")]
            public int? SourceProjectId { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("author_id")]
            public int? AuthorId { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("assignee_id")]
            public int? AssigneeId { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("title")]
            public string? Title { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("created_at")]
            public string? CreatedAt { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("updated_at")]
            public string? UpdatedAt { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("milestone_id")]
            public object? MilestoneId { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("state")]
            public string? State { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("merge_status")]
            public string? MergeStatus { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("target_project_id")]
            public int? TargetProjectId { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("iid")]
            public int? Iid { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("description")]
            public string? Description { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("source")]
            public Source? Source { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("target")]
            public Target? Target { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("last_commit")]
            public LastCommit? LastCommit { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("work_in_progress")]
            public bool? WorkInProgress { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("url")]
            public string? Url { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("action")]
            public string? Action { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("assignee")]
            public Assignee? Assignee { get; set; }
        }

        public class Source : Project
        {
        }

        public class Target : Project
        {
        }

        public class Assignee
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

        public class Changes
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty("updated_by_id")]
            public UpdatedById? UpdatedById { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("updated_at")]
            public UpdatedAt? UpdatedAt { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("labels")]
            public Labels? Labels { get; set; }
        }

        public class Labels
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty("previous")]
            public Previou[]? Previous { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("current")]
            public Current[]? Current { get; set; }
        }

        public class Previou : Label
        {
        }

        public class Current : Label
        {
        }

        public class Label
        {
            /// <summary>
            ///
            /// </summary>
            [JsonProperty("id")]
            public int? Id { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("title")]
            public string? Title { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("color")]
            public string? Color { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("project_id")]
            public int? ProjectId { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("created_at")]
            public string? CreatedAt { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("updated_at")]
            public string? UpdatedAt { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("template")]
            public bool? Template { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("description")]
            public string? Description { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            ///
            /// </summary>
            [JsonProperty("group_id")]
            public int? GroupId { get; set; }
        }
    }
}