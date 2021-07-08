using System.Net.Http;
using System.Threading.Tasks;
using TdonCashless.Microservices.Gateway.API.DTOs;
using Newtonsoft.Json;

namespace TdonCashless.Microservices.Gateway.API.Services
{
    public class ValidatedTokenService : IValidatedTokenService
    {
        private readonly HttpClient _apiClient;
        public ValidatedTokenService(HttpClient httpClient)
        {
            _apiClient = httpClient;
        }

        public async Task<bool> ValidateCard(RevalidateCustomerCardTokenDTO revalidateCustomerCard)
        {
            var uri = "https://localhost:5003/api/RevalidateCustomerCard";
            var content = new StringContent(JsonConvert.SerializeObject(revalidateCustomerCard), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync(uri, content);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<bool>(responseBody);
        }
    }
}