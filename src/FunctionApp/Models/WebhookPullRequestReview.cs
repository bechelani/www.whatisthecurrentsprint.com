using System;
using Newtonsoft.Json;

namespace WhatIsTheCurrentSprint.FunctionApp.Models
{
    public class WebhookPullRequestReview
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "commit_id")]
        public string CommitId { get; set; }

        [JsonProperty(PropertyName = "submitted_at")]
        public DateTimeOffset SubmittedAt { get; set; }

        [JsonProperty(PropertyName = "submitted_by")]
        public string SubmittedBy { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }
    }
}
