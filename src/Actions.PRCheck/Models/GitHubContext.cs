
using Newtonsoft.Json;
using System;
namespace Actions.PRCheck.Context
{
    public partial class GitHubContext
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("repository_owner")]
        public string RepositoryOwner { get; set; }

        [JsonProperty("repositoryUrl")]
        public string RepositoryUrl { get; set; }

        [JsonProperty("run_id")]
        
        public long RunId { get; set; }

        [JsonProperty("run_number")]
        
        public long RunNumber { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("workflow")]
        public string Workflow { get; set; }

        [JsonProperty("head_ref")]
        public string HeadRef { get; set; }

        [JsonProperty("base_ref")]
        public string BaseRef { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event")]
        public Event Event { get; set; }

        [JsonProperty("server_url")]
        public Uri ServerUrl { get; set; }

        [JsonProperty("api_url")]
        public Uri ApiUrl { get; set; }

        [JsonProperty("graphql_url")]
        public Uri GraphqlUrl { get; set; }

        [JsonProperty("workspace")]
        public string Workspace { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }
    }

    public partial class Event
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("pull_request")]
        public PullRequest PullRequest { get; set; }

        [JsonProperty("repository")]
        public Repo Repository { get; set; }

        [JsonProperty("sender")]
        public Sender Sender { get; set; }
    }

    public partial class PullRequest
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("active_lock_reason")]
        public object ActiveLockReason { get; set; }

        [JsonProperty("additions")]
        public long Additions { get; set; }

        [JsonProperty("assignee")]
        public object Assignee { get; set; }

        [JsonProperty("assignees")]
        public object[] Assignees { get; set; }

        [JsonProperty("author_association")]
        public string AuthorAssociation { get; set; }

        [JsonProperty("base")]
        public Base Base { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("changed_files")]
        public long ChangedFiles { get; set; }

        [JsonProperty("closed_at")]
        public object ClosedAt { get; set; }

        [JsonProperty("comments")]
        public long Comments { get; set; }

        [JsonProperty("comments_url")]
        public Uri CommentsUrl { get; set; }

        [JsonProperty("commits")]
        public long Commits { get; set; }

        [JsonProperty("commits_url")]
        public Uri CommitsUrl { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("deletions")]
        public long Deletions { get; set; }

        [JsonProperty("diff_url")]
        public Uri DiffUrl { get; set; }

        [JsonProperty("draft")]
        public bool Draft { get; set; }

        [JsonProperty("head")]
        public Base Head { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("issue_url")]
        public Uri IssueUrl { get; set; }

        [JsonProperty("labels")]
        public object[] Labels { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("maintainer_can_modify")]
        public bool MaintainerCanModify { get; set; }

        [JsonProperty("merge_commit_sha")]
        public object MergeCommitSha { get; set; }

        [JsonProperty("mergeable")]
        public object Mergeable { get; set; }

        [JsonProperty("mergeable_state")]
        public string MergeableState { get; set; }

        [JsonProperty("merged")]
        public bool Merged { get; set; }

        [JsonProperty("merged_at")]
        public object MergedAt { get; set; }

        [JsonProperty("merged_by")]
        public object MergedBy { get; set; }

        [JsonProperty("milestone")]
        public object Milestone { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("patch_url")]
        public Uri PatchUrl { get; set; }

        [JsonProperty("rebaseable")]
        public object Rebaseable { get; set; }

        [JsonProperty("requested_reviewers")]
        public object[] RequestedReviewers { get; set; }

        [JsonProperty("requested_teams")]
        public object[] RequestedTeams { get; set; }

        [JsonProperty("review_comment_url")]
        public string ReviewCommentUrl { get; set; }

        [JsonProperty("review_comments")]
        public long ReviewComments { get; set; }

        [JsonProperty("review_comments_url")]
        public Uri ReviewCommentsUrl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("statuses_url")]
        public Uri StatusesUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("user")]
        public Sender User { get; set; }
    }

    public partial class Base
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("repo")]
        public Repo Repo { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("user")]
        public Sender User { get; set; }
    }

    public partial class Repo
    {
        [JsonProperty("allow_merge_commit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowMergeCommit { get; set; }

        [JsonProperty("allow_rebase_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowRebaseMerge { get; set; }

        [JsonProperty("allow_squash_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSquashMerge { get; set; }

        [JsonProperty("archive_url")]
        public string ArchiveUrl { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("assignees_url")]
        public string AssigneesUrl { get; set; }

        [JsonProperty("blobs_url")]
        public string BlobsUrl { get; set; }

        [JsonProperty("branches_url")]
        public string BranchesUrl { get; set; }

        [JsonProperty("clone_url")]
        public Uri CloneUrl { get; set; }

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

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }

        [JsonProperty("delete_branch_on_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteBranchOnMerge { get; set; }

        [JsonProperty("deployments_url")]
        public Uri DeploymentsUrl { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("downloads_url")]
        public Uri DownloadsUrl { get; set; }

        [JsonProperty("events_url")]
        public Uri EventsUrl { get; set; }

        [JsonProperty("fork")]
        public bool Fork { get; set; }

        [JsonProperty("forks")]
        public long Forks { get; set; }

        [JsonProperty("forks_count")]
        public long ForksCount { get; set; }

        [JsonProperty("forks_url")]
        public Uri ForksUrl { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("git_commits_url")]
        public string GitCommitsUrl { get; set; }

        [JsonProperty("git_refs_url")]
        public string GitRefsUrl { get; set; }

        [JsonProperty("git_tags_url")]
        public string GitTagsUrl { get; set; }

        [JsonProperty("git_url")]
        public string GitUrl { get; set; }

        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        [JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        [JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        [JsonProperty("has_projects")]
        public bool HasProjects { get; set; }

        [JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        [JsonProperty("homepage")]
        public object Homepage { get; set; }

        [JsonProperty("hooks_url")]
        public Uri HooksUrl { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

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

        [JsonProperty("language")]
        public object Language { get; set; }

        [JsonProperty("languages_url")]
        public Uri LanguagesUrl { get; set; }

        [JsonProperty("license")]
        public object License { get; set; }

        [JsonProperty("merges_url")]
        public Uri MergesUrl { get; set; }

        [JsonProperty("milestones_url")]
        public string MilestonesUrl { get; set; }

        [JsonProperty("mirror_url")]
        public object MirrorUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("notifications_url")]
        public string NotificationsUrl { get; set; }

        [JsonProperty("open_issues")]
        public long OpenIssues { get; set; }

        [JsonProperty("open_issues_count")]
        public long OpenIssuesCount { get; set; }

        [JsonProperty("owner")]
        public Sender Owner { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("pulls_url")]
        public string PullsUrl { get; set; }

        [JsonProperty("pushed_at")]
        public DateTimeOffset PushedAt { get; set; }

        [JsonProperty("releases_url")]
        public string ReleasesUrl { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("ssh_url")]
        public string SshUrl { get; set; }

        [JsonProperty("stargazers_count")]
        public long StargazersCount { get; set; }

        [JsonProperty("stargazers_url")]
        public Uri StargazersUrl { get; set; }

        [JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }

        [JsonProperty("subscribers_url")]
        public Uri SubscribersUrl { get; set; }

        [JsonProperty("subscription_url")]
        public Uri SubscriptionUrl { get; set; }

        [JsonProperty("svn_url")]
        public Uri SvnUrl { get; set; }

        [JsonProperty("tags_url")]
        public Uri TagsUrl { get; set; }

        [JsonProperty("teams_url")]
        public Uri TeamsUrl { get; set; }

        [JsonProperty("trees_url")]
        public string TreesUrl { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("watchers")]
        public long Watchers { get; set; }

        [JsonProperty("watchers_count")]
        public long WatchersCount { get; set; }
    }

    public partial class Sender
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("commits")]
        public Comments Commits { get; set; }

        [JsonProperty("html")]
        public Comments Html { get; set; }

        [JsonProperty("issue")]
        public Comments Issue { get; set; }

        [JsonProperty("review_comment")]
        public Comments ReviewComment { get; set; }

        [JsonProperty("review_comments")]
        public Comments ReviewComments { get; set; }

        [JsonProperty("self")]
        public Comments Self { get; set; }

        [JsonProperty("statuses")]
        public Comments Statuses { get; set; }
    }

    public partial class Comments
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
