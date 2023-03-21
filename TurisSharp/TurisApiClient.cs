using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace TurisSharp
{
    public class TurisApiClient
    {
        public string BaseUri;
        private readonly string _grantType;
        private readonly string _accessToken;

        public TurisApiClient(string baseUri, string accessToken)
        {
             BaseUri = baseUri;
            _grantType = TurisConsts.GrantType;
            _accessToken = accessToken;
        }

        public async Task<T> ExecuteAsync<T>(HttpMethod method, string requestUrl, object? data = null)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_accessToken}");
                var requestMessage = new HttpRequestMessage(method, $"{BaseUri}{requestUrl}");

                if (data != null)
                {
                    var json = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                }

                var response = await client.SendAsync(requestMessage);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    var exception = JsonConvert.DeserializeObject<TurisException>(result);
                    exception.Message = result;
                    exception.StatusCode = response.StatusCode;
                    throw exception;
                }

                var responseObj = JsonConvert.DeserializeObject<T>(result);
                return responseObj;
            }
        }

        public async Task<TurisTokenResponse> GetTokenAsync(string clientId, string clientSecret)
        {
            using (var client = new HttpClient())
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, TurisConsts.TokenUrl);
                var body = new
                {
                    grant_type = _grantType,
                    client_id = clientId,
                    client_secret = clientSecret
                };

                var json = JsonConvert.SerializeObject(body, Formatting.None, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
                requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(requestMessage);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    var exception = JsonConvert.DeserializeObject<TurisException>(result);
                    exception.Message = result;
                    throw exception;
                }
                var responseObj = JsonConvert.DeserializeObject<TurisTokenResponse>(result);
                return responseObj;
            }
        }
    }
}
