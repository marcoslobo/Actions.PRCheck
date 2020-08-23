using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

namespace Actions.PRCheck
{
    public partial class GitHubModels
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("diff_url")]
        public Uri DiffUrl { get; set; }

        [JsonProperty("patch_url")]
        public Uri PatchUrl { get; set; }

        [JsonProperty("issue_url")]
        public Uri IssueUrl { get; set; }

        [JsonProperty("commits_url")]
        public Uri CommitsUrl { get; set; }

        [JsonProperty("review_comments_url")]
        public Uri ReviewCommentsUrl { get; set; }

        [JsonProperty("review_comment_url")]
        public string ReviewCommentUrl { get; set; }

        [JsonProperty("comments_url")]
        public Uri CommentsUrl { get; set; }

        [JsonProperty("statuses_url")]
        public Uri StatusesUrl { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user")]
        public Assignee User { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("labels")]
        public Label[] Labels { get; set; }

        [JsonProperty("milestone")]
        public Milestone Milestone { get; set; }

        [JsonProperty("active_lock_reason")]
        public string ActiveLockReason { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty("merged_at")]
        public string MergedAt { get; set; }

        [JsonProperty("merge_commit_sha")]
        public string MergeCommitSha { get; set; }

        [JsonProperty("assignee")]
        public Assignee Assignee { get; set; }

        [JsonProperty("assignees")]
        public Assignee[] Assignees { get; set; }

        [JsonProperty("requested_reviewers")]
        public Assignee[] RequestedReviewers { get; set; }

        [JsonProperty("requested_teams")]
        public RequestedTeam[] RequestedTeams { get; set; }

        [JsonProperty("head")]
        public Base Head { get; set; }

        [JsonProperty("base")]
        public Base Base { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("author_association")]
        public string AuthorAssociation { get; set; }

        [JsonProperty("draft")]
        public bool Draft { get; set; }
    }

    public partial class Assignee
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }
    }

    public partial class Base
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("user")]
        public Assignee User { get; set; }

        [JsonProperty("repo")]
        public Repo Repo { get; set; }
    }

    public partial class Repo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("owner")]
        public Assignee Owner { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fork")]
        public bool Fork { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("archive_url")]
        public string ArchiveUrl { get; set; }

        [JsonProperty("assignees_url")]
        public string AssigneesUrl { get; set; }

        [JsonProperty("blobs_url")]
        public string BlobsUrl { get; set; }

        [JsonProperty("branches_url")]
        public string BranchesUrl { get; set; }

        [JsonProperty("collaborators_url")]
        public string CollaboratorsUrl { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        [JsonProperty("compare_url")]
        public string CompareUrl { get; set; }

        [JsonProperty("contents_url")]
        public string ContentsUrl { get; set; }

        [JsonProperty("contributors_url")]
        public Uri ContributorsUrl { get; set; }

        [JsonProperty("deployments_url")]
        public Uri DeploymentsUrl { get; set; }

        [JsonProperty("downloads_url")]
        public Uri DownloadsUrl { get; set; }

        [JsonProperty("events_url")]
        public Uri EventsUrl { get; set; }

        [JsonProperty("forks_url")]
        public Uri ForksUrl { get; set; }

        [JsonProperty("git_commits_url")]
        public string GitCommitsUrl { get; set; }

        [JsonProperty("git_refs_url")]
        public string GitRefsUrl { get; set; }

        [JsonProperty("git_tags_url")]
        public string GitTagsUrl { get; set; }

        [JsonProperty("git_url")]
        public string GitUrl { get; set; }

        [JsonProperty("issue_comment_url")]
        public string IssueCommentUrl { get; set; }

        [JsonProperty("issue_events_url")]
        public string IssueEventsUrl { get; set; }

        [JsonProperty("issues_url")]
        public string IssuesUrl { get; set; }

        [JsonProperty("keys_url")]
        public string KeysUrl { get; set; }

        [JsonProperty("labels_url")]
        public string LabelsUrl { get; set; }

        [JsonProperty("languages_url")]
        public Uri LanguagesUrl { get; set; }

        [JsonProperty("merges_url")]
        public Uri MergesUrl { get; set; }

        [JsonProperty("milestones_url")]
        public string MilestonesUrl { get; set; }

        [JsonProperty("notifications_url")]
        public string NotificationsUrl { get; set; }

        [JsonProperty("pulls_url")]
        public string PullsUrl { get; set; }

        [JsonProperty("releases_url")]
        public string ReleasesUrl { get; set; }

        [JsonProperty("ssh_url")]
        public string SshUrl { get; set; }

        [JsonProperty("stargazers_url")]
        public Uri StargazersUrl { get; set; }

        [JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }

        [JsonProperty("subscribers_url")]
        public Uri SubscribersUrl { get; set; }

        [JsonProperty("subscription_url")]
        public Uri SubscriptionUrl { get; set; }

        [JsonProperty("tags_url")]
        public Uri TagsUrl { get; set; }

        [JsonProperty("teams_url")]
        public Uri TeamsUrl { get; set; }

        [JsonProperty("trees_url")]
        public string TreesUrl { get; set; }

        [JsonProperty("clone_url")]
        public Uri CloneUrl { get; set; }

        [JsonProperty("mirror_url")]
        public string MirrorUrl { get; set; }

        [JsonProperty("hooks_url")]
        public Uri HooksUrl { get; set; }

        [JsonProperty("svn_url")]
        public Uri SvnUrl { get; set; }

        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }

        [JsonProperty("language")]
        public object Language { get; set; }

        [JsonProperty("forks_count")]
        public long ForksCount { get; set; }

        [JsonProperty("stargazers_count")]
        public long StargazersCount { get; set; }

        [JsonProperty("watchers_count")]
        public long WatchersCount { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }

        [JsonProperty("open_issues_count")]
        public long OpenIssuesCount { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("topics")]
        public string[] Topics { get; set; }

        [JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        [JsonProperty("has_projects")]
        public bool HasProjects { get; set; }

        [JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        [JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("pushed_at")]
        public DateTimeOffset PushedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("permissions")]
        public Permissions Permissions { get; set; }

        [JsonProperty("allow_rebase_merge")]
        public bool AllowRebaseMerge { get; set; }

        [JsonProperty("template_repository")]
        public object TemplateRepository { get; set; }

        [JsonProperty("temp_clone_token")]
        public string TempCloneToken { get; set; }

        [JsonProperty("allow_squash_merge")]
        public bool AllowSquashMerge { get; set; }

        [JsonProperty("delete_branch_on_merge")]
        public bool DeleteBranchOnMerge { get; set; }

        [JsonProperty("allow_merge_commit")]
        public bool AllowMergeCommit { get; set; }

        [JsonProperty("subscribers_count")]
        public long SubscribersCount { get; set; }

        [JsonProperty("network_count")]
        public long NetworkCount { get; set; }
    }

    public partial class Permissions
    {
        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("push")]
        public bool Push { get; set; }

        [JsonProperty("pull")]
        public bool Pull { get; set; }
    }

    public partial class Label
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("self")]
        public Comments Self { get; set; }

        [JsonProperty("html")]
        public Comments Html { get; set; }

        [JsonProperty("issue")]
        public Comments Issue { get; set; }

        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("review_comments")]
        public Comments ReviewComments { get; set; }

        [JsonProperty("review_comment")]
        public Comments ReviewComment { get; set; }

        [JsonProperty("commits")]
        public Comments Commits { get; set; }

        [JsonProperty("statuses")]
        public Comments Statuses { get; set; }
    }

    public partial class Comments
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public partial class Milestone
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("labels_url")]
        public Uri LabelsUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("creator")]
        public Assignee Creator { get; set; }

        [JsonProperty("open_issues")]
        public long OpenIssues { get; set; }

        [JsonProperty("closed_issues")]
        public long ClosedIssues { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty("due_on")]
        public string DueOn { get; set; }
    }

    public partial class RequestedTeam
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("members_url")]
        public string MembersUrl { get; set; }

        [JsonProperty("repositories_url")]
        public Uri RepositoriesUrl { get; set; }

        [JsonProperty("parent")]
        public object Parent { get; set; }
    }

    public enum EventsUrl { HttpsApiGithubComUsersHubotEventsPrivacy, HttpsApiGithubComUsersOctocatEventsPrivacy, HttpsApiGithubComUsersOtherUserEventsPrivacy };

    public enum FollowingUrl { HttpsApiGithubComUsersHubotFollowingOtherUser, HttpsApiGithubComUsersOctocatFollowingOtherUser, HttpsApiGithubComUsersOtherUserFollowingOtherUser };

    public enum GistsUrl { HttpsApiGithubComUsersHubotGistsGistId, HttpsApiGithubComUsersOctocatGistsGistId, HttpsApiGithubComUsersOtherUserGistsGistId };

    public enum Login { Hubot, Octocat, OtherUser };

    public enum NodeId { Mdq6VxNlcjE };

    public enum StarredUrl { HttpsApiGithubComUsersHubotStarredOwnerRepo, HttpsApiGithubComUsersOctocatStarredOwnerRepo, HttpsApiGithubComUsersOtherUserStarredOwnerRepo };

    public enum TypeEnum { User };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                EventsUrlConverter.Singleton,
                FollowingUrlConverter.Singleton,
                GistsUrlConverter.Singleton,
                LoginConverter.Singleton,
                NodeIdConverter.Singleton,
                StarredUrlConverter.Singleton,
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class EventsUrlConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EventsUrl) || t == typeof(EventsUrl?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "https://api.github.com/users/hubot/events{/privacy}":
                    return EventsUrl.HttpsApiGithubComUsersHubotEventsPrivacy;
                case "https://api.github.com/users/octocat/events{/privacy}":
                    return EventsUrl.HttpsApiGithubComUsersOctocatEventsPrivacy;
                case "https://api.github.com/users/other_user/events{/privacy}":
                    return EventsUrl.HttpsApiGithubComUsersOtherUserEventsPrivacy;
            }
            throw new Exception("Cannot unmarshal type EventsUrl");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EventsUrl)untypedValue;
            switch (value)
            {
                case EventsUrl.HttpsApiGithubComUsersHubotEventsPrivacy:
                    serializer.Serialize(writer, "https://api.github.com/users/hubot/events{/privacy}");
                    return;
                case EventsUrl.HttpsApiGithubComUsersOctocatEventsPrivacy:
                    serializer.Serialize(writer, "https://api.github.com/users/octocat/events{/privacy}");
                    return;
                case EventsUrl.HttpsApiGithubComUsersOtherUserEventsPrivacy:
                    serializer.Serialize(writer, "https://api.github.com/users/other_user/events{/privacy}");
                    return;
            }
            throw new Exception("Cannot marshal type EventsUrl");
        }

        public static readonly EventsUrlConverter Singleton = new EventsUrlConverter();
    }

    internal class FollowingUrlConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FollowingUrl) || t == typeof(FollowingUrl?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "https://api.github.com/users/hubot/following{/other_user}":
                    return FollowingUrl.HttpsApiGithubComUsersHubotFollowingOtherUser;
                case "https://api.github.com/users/octocat/following{/other_user}":
                    return FollowingUrl.HttpsApiGithubComUsersOctocatFollowingOtherUser;
                case "https://api.github.com/users/other_user/following{/other_user}":
                    return FollowingUrl.HttpsApiGithubComUsersOtherUserFollowingOtherUser;
            }
            throw new Exception("Cannot unmarshal type FollowingUrl");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FollowingUrl)untypedValue;
            switch (value)
            {
                case FollowingUrl.HttpsApiGithubComUsersHubotFollowingOtherUser:
                    serializer.Serialize(writer, "https://api.github.com/users/hubot/following{/other_user}");
                    return;
                case FollowingUrl.HttpsApiGithubComUsersOctocatFollowingOtherUser:
                    serializer.Serialize(writer, "https://api.github.com/users/octocat/following{/other_user}");
                    return;
                case FollowingUrl.HttpsApiGithubComUsersOtherUserFollowingOtherUser:
                    serializer.Serialize(writer, "https://api.github.com/users/other_user/following{/other_user}");
                    return;
            }
            throw new Exception("Cannot marshal type FollowingUrl");
        }

        public static readonly FollowingUrlConverter Singleton = new FollowingUrlConverter();
    }

    internal class GistsUrlConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GistsUrl) || t == typeof(GistsUrl?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "https://api.github.com/users/hubot/gists{/gist_id}":
                    return GistsUrl.HttpsApiGithubComUsersHubotGistsGistId;
                case "https://api.github.com/users/octocat/gists{/gist_id}":
                    return GistsUrl.HttpsApiGithubComUsersOctocatGistsGistId;
                case "https://api.github.com/users/other_user/gists{/gist_id}":
                    return GistsUrl.HttpsApiGithubComUsersOtherUserGistsGistId;
            }
            throw new Exception("Cannot unmarshal type GistsUrl");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GistsUrl)untypedValue;
            switch (value)
            {
                case GistsUrl.HttpsApiGithubComUsersHubotGistsGistId:
                    serializer.Serialize(writer, "https://api.github.com/users/hubot/gists{/gist_id}");
                    return;
                case GistsUrl.HttpsApiGithubComUsersOctocatGistsGistId:
                    serializer.Serialize(writer, "https://api.github.com/users/octocat/gists{/gist_id}");
                    return;
                case GistsUrl.HttpsApiGithubComUsersOtherUserGistsGistId:
                    serializer.Serialize(writer, "https://api.github.com/users/other_user/gists{/gist_id}");
                    return;
            }
            throw new Exception("Cannot marshal type GistsUrl");
        }

        public static readonly GistsUrlConverter Singleton = new GistsUrlConverter();
    }

    internal class LoginConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Login) || t == typeof(Login?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "hubot":
                    return Login.Hubot;
                case "octocat":
                    return Login.Octocat;
                case "other_user":
                    return Login.OtherUser;
            }
            throw new Exception("Cannot unmarshal type Login");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Login)untypedValue;
            switch (value)
            {
                case Login.Hubot:
                    serializer.Serialize(writer, "hubot");
                    return;
                case Login.Octocat:
                    serializer.Serialize(writer, "octocat");
                    return;
                case Login.OtherUser:
                    serializer.Serialize(writer, "other_user");
                    return;
            }
            throw new Exception("Cannot marshal type Login");
        }

        public static readonly LoginConverter Singleton = new LoginConverter();
    }

    internal class NodeIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NodeId) || t == typeof(NodeId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "MDQ6VXNlcjE=")
            {
                return NodeId.Mdq6VxNlcjE;
            }
            throw new Exception("Cannot unmarshal type NodeId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NodeId)untypedValue;
            if (value == NodeId.Mdq6VxNlcjE)
            {
                serializer.Serialize(writer, "MDQ6VXNlcjE=");
                return;
            }
            throw new Exception("Cannot marshal type NodeId");
        }

        public static readonly NodeIdConverter Singleton = new NodeIdConverter();
    }

    internal class StarredUrlConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StarredUrl) || t == typeof(StarredUrl?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "https://api.github.com/users/hubot/starred{/owner}{/repo}":
                    return StarredUrl.HttpsApiGithubComUsersHubotStarredOwnerRepo;
                case "https://api.github.com/users/octocat/starred{/owner}{/repo}":
                    return StarredUrl.HttpsApiGithubComUsersOctocatStarredOwnerRepo;
                case "https://api.github.com/users/other_user/starred{/owner}{/repo}":
                    return StarredUrl.HttpsApiGithubComUsersOtherUserStarredOwnerRepo;
            }
            throw new Exception("Cannot unmarshal type StarredUrl");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StarredUrl)untypedValue;
            switch (value)
            {
                case StarredUrl.HttpsApiGithubComUsersHubotStarredOwnerRepo:
                    serializer.Serialize(writer, "https://api.github.com/users/hubot/starred{/owner}{/repo}");
                    return;
                case StarredUrl.HttpsApiGithubComUsersOctocatStarredOwnerRepo:
                    serializer.Serialize(writer, "https://api.github.com/users/octocat/starred{/owner}{/repo}");
                    return;
                case StarredUrl.HttpsApiGithubComUsersOtherUserStarredOwnerRepo:
                    serializer.Serialize(writer, "https://api.github.com/users/other_user/starred{/owner}{/repo}");
                    return;
            }
            throw new Exception("Cannot marshal type StarredUrl");
        }

        public static readonly StarredUrlConverter Singleton = new StarredUrlConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "User")
            {
                return TypeEnum.User;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.User)
            {
                serializer.Serialize(writer, "User");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
