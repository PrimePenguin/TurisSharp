using System.Net.Http;
using System.Threading.Tasks;
using TurisSharp.Entities;

namespace TurisSharp
{
    public class TurisProductService
    {
        public readonly TurisApiClient ApiClient;

        public TurisProductService(string baseUrl, string accessToken)
        {
            ApiClient = new TurisApiClient(baseUrl, accessToken);
        }

        public async Task<TurisProducts> GetTurisProducts()
        {
            return await ApiClient.ExecuteAsync<TurisProducts>(HttpMethod.Get, TurisConsts.ProductsUrl);
        }

        public async Task<TurisProduct> GetTurisProduct(long productId)
        {
            var uri = $"{TurisConsts.ProductsUrl}{productId}";
            return await ApiClient.ExecuteAsync<TurisProduct>(HttpMethod.Get, uri);
        }

        public async Task<TurisProductGroups> GetTurisProductGroups()
        {
            return await ApiClient.ExecuteAsync<TurisProductGroups>(HttpMethod.Get, TurisConsts.ProductsGroupsUrl);
        }
        public async Task<TurisProductGroup> GetTurisProductGroup(int groupId)
        {
            var uri = $"{TurisConsts.ProductsGroupsUrl}{groupId}";
            return await ApiClient.ExecuteAsync<TurisProductGroup>(HttpMethod.Get, uri);
        }

        public async Task<TurisProductVariants> GetTurisProductVariants()
        {
            return await ApiClient.ExecuteAsync<TurisProductVariants>(HttpMethod.Get, TurisConsts.ProductsVariantsUrl);
        }

        public async Task<TurisProductVariant> GetTurisProductVariant(int variantId)
        {
            var uri = $"{TurisConsts.ProductsVariantsUrl}{variantId}";
            return await ApiClient.ExecuteAsync<TurisProductVariant>(HttpMethod.Get, uri);
        }

        public async Task<TurisProduct> PatchProduct(long productId, ProductPatch product)
        {
            var uri = $"{TurisConsts.ProductsUrl}{productId}";
            return await ApiClient.ExecuteAsync<TurisProduct>(HttpMethod.Patch, uri, product);
        }

        public async Task<string> DeleteTurisProduct(long productId)
        {
            var uri = $"{TurisConsts.ProductsUrl}{productId}";
            return await ApiClient.ExecuteAsync<string>(HttpMethod.Delete, uri);
        }

    }
}
