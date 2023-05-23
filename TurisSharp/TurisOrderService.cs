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

        public async Task<TurisOrders> GetOrders()
        {
            return await ApiClient.ExecuteAsync<TurisOrders>(HttpMethod.Get, TurisConsts.OrdersUrl);
        }

        public async Task<TurisOrder> GetOrder(long orderId)
        {
            var uri = $"{TurisConsts.OrdersUrl}{orderId}";
            return await ApiClient.ExecuteAsync<TurisOrder>(HttpMethod.Get, uri);
        }

        public async Task<string> UpdateOrder(long orderId, OrderUpdateRequest request)
        {
            var uri = $"{TurisConsts.OrdersUrl}{orderId}";
            return await ApiClient.ExecuteAsync<string>(HttpMethod.Put, uri, request);
        }

        public async Task<string> UpdateOrderItems(long orderId, UpdateOrderItemsRequest request)
        {
            var uri = $"{TurisConsts.OrdersUrl}{orderId}/items";
            return await ApiClient.ExecuteAsync<string>(HttpMethod.Put, uri, request);
        }

        public async Task<TurisOrder> CreateOrder(CreateOrderRequest request)
        {
            return await ApiClient.ExecuteAsync<TurisOrder>(HttpMethod.Put, TurisConsts.OrdersUrl, request);
        }

        public async Task<TurisOrders> GetOrdersByStatus(int statusId)
        {
            var uri = $"{TurisConsts.OrdersUrl}status/{statusId}";
            return await ApiClient.ExecuteAsync<TurisOrders>(HttpMethod.Get, uri);
        }

        public async Task<TurisOrders> GetOrdersByDateOfCreation(long fromDate, long toDate)
        {
            var uri = $"{TurisConsts.OrdersUrl}created/{fromDate}/{toDate}";
            return await ApiClient.ExecuteAsync<TurisOrders>(HttpMethod.Get, uri);
        }

        public async Task<TurisOrders> GetOrdersByDateOfUpdation(long fromDate, long toDate)
        {
            var uri = $"{TurisConsts.OrdersUrl}updated/{fromDate}/{toDate}";
            return await ApiClient.ExecuteAsync<TurisOrders>(HttpMethod.Get, uri);
        }

        public async Task<string> DeleteOrder(long orderId)
        {
            var uri = $"{TurisConsts.OrdersUrl}{orderId}";
            return await ApiClient.ExecuteAsync<string>(HttpMethod.Delete, uri);
        }
    }
}
