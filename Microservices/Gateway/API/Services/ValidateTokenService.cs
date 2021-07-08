using System.Net.Http;
using System.Threading.Tasks;
using TdonCashless.Microservices.Gateway.API.DTOs;
using Newtonsoft.Json;

namespace TdonCashless.Microservices.Gateway.API.Services
{
    public class ValidateTokenService : IValidateTokenService
    {
        private readonly HttpClient _apiClient;
        public ValidateTokenService(HttpClient httpClient)
        {
            _apiClient = httpClient;
        }

        public async Task<bool> ValidateCard(ValidateCardDTO validateCardDTO)
        {
            var uri = "https://localhost:5003/api/ValidateToken";
            var content = new StringContent(JsonConvert.SerializeObject(validateCardDTO), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync(uri, content);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<bool>(responseBody);
        }
    }
}