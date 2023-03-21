using System.Net.Http;
using System.Threading.Tasks;
using TurisSharp.Entities;

namespace TurisSharp
{
    public class TurisSubscriptionService
    {
        public readonly TurisApiClient ApiClient;

        public TurisSubscriptionService(string baseUrl, string accessToken)
        {
            ApiClient = new TurisApiClient(baseUrl, accessToken);
        }

        public async Task<TurisSubscriptions> GetTurisSubscriptions()
        {
            return await ApiClient.ExecuteAsync<TurisSubscriptions>(HttpMethod.Get, TurisConsts.SubscriptionUrl);
        }

        public async Task<TurisSubscription> GetTurisSubscription(int subscriptionId)
        {
            var uri = $"{TurisConsts.SubscriptionUrl}{subscriptionId}";
            return await ApiClient.ExecuteAsync<TurisSubscription>(HttpMethod.Get, uri);
        }

        public async Task<string> DeleteTurisSubscription(int subscriptionId)
        {
            var uri = $"{TurisConsts.SubscriptionUrl}{subscriptionId}";
            return await ApiClient.ExecuteAsync<string>(HttpMethod.Delete, uri);
        }

        public async Task<TurisSubscription> CreateSubscription(SubscriptionRequest request)
        {
            return await ApiClient.ExecuteAsync<TurisSubscription>(HttpMethod.Post, TurisConsts.SubscriptionUrl, request);
        }
    }
}
