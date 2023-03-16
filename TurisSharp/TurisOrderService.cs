using System.Net.Http;
using System.Threading.Tasks;
using TurisSharp.Entities;

namespace TurisSharp
{
    public class TurisOrderService
    {
        public readonly TurisApiClient ApiClient;

        public TurisOrderService(string baseUrl, string accessToken)
        {
            ApiClient = new TurisApiClient(baseUrl, accessToken);
        }

        public async Task<TurisOrders> GetTurisOrders()
        {
            return await ApiClient.ExecuteAsync<TurisOrders>(HttpMethod.Get, TurisConsts.OrdersUrl);
        }
        /// <summary>
        /// Get turis order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public async Task<TurisOrder> GetTurisOrder(long orderId)
        {
            var uri = $"{TurisConsts.OrdersUrl}{orderId}";
            return await ApiClient.ExecuteAsync<TurisOrder>(HttpMethod.Get, uri);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<string> UpdateTurisOrder(long orderId, OrderUpdateRequest request)
        {
            var uri = $"{TurisConsts.OrdersUrl}{orderId}";
            return await ApiClient.ExecuteAsync<string>(HttpMethod.Put, uri, request);
        }
         
        public async Task<string> UpdateTurisOrderItems(long orderId, UpdateOrderItemsRequest request)
        {
            var uri = $"{TurisConsts.OrdersUrl}{orderId}/items";
            return await ApiClient.ExecuteAsync<string>(HttpMethod.Put, uri, request);
        }


        public async Task<TurisOrder> CreateTurisOrder(CreateOrderRequest request)
        {
           return await ApiClient.ExecuteAsync<TurisOrder>(HttpMethod.Put, TurisConsts.OrdersUrl, request);
        }

        public async Task<TurisOrders> GetTurisOrdersByStatus(int statusId)
        {
            var uri = $"{TurisConsts.OrdersUrl}status/{statusId}";
            return await ApiClient.ExecuteAsync<TurisOrders>(HttpMethod.Get, uri);
        }

        public async Task<TurisOrders> GetTurisOrdersByDateOfCreation(long fromDate, long toDate)
        {
            var uri = $"{TurisConsts.OrdersUrl}created/{fromDate}/{toDate}";
            return await ApiClient.ExecuteAsync<TurisOrders>(HttpMethod.Get, uri);
        }

        public async Task<TurisOrders> GetTurisOrdersByDateOfUpdation(long fromDate, long toDate)
        {
            var uri = $"{TurisConsts.OrdersUrl}updated/{fromDate}/{toDate}";
            return await ApiClient.ExecuteAsync<TurisOrders>(HttpMethod.Get, uri);
        }

        public async Task<string> DeleteTurisOrder(long orderId)
        {
            var uri = $"{TurisConsts.OrdersUrl}{orderId}";
            return await ApiClient.ExecuteAsync<string>(HttpMethod.Delete, uri);
        }



    }
}
