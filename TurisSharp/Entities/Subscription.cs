using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TurisSharp.Entities
{
    public class TurisSubscriptions
    {
        [JsonProperty("data")]
        public List<Subscription> Subscriptions { get; set; }
    }

    public class TurisSubscription
    {
        [JsonProperty("data")]
        public Subscription Subscription { get; set; }
    }
    public class Subscription
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("endpoint")]
        public Uri Endpoint { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public class SubscriptionRequest
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("endpoint")]
        public string Endpoint { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class SubscriptionResponse
    {
        [JsonProperty("subscription_id")]
        public long SubscriptionId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("resource_id")]
        public long ResourceId { get; set; }
    }
}
