using System.Net.Http;
using System.Threading.Tasks;
using TdonCashless.Microservices.Gateway.API.DTOs;
using Newtonsoft.Json;

namespace TdonCashless.Microservices.Gateway.API.Services
{
    public class CreateCustomerCardService : ICreateCustomerCardService
    {
        private readonly HttpClient _apiClient;
        public CreateCustomerCardService(HttpClient httpClient)
        {
            _apiClient = httpClient;
        }

        public async Task<CreatedCard> CreateCard(CreateCardDTO createCardDto)
        {
            var uri = "https://localhost:5001/api/CreateCustomerCard";
            var content = new StringContent(JsonConvert.SerializeObject(createCardDto), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync(uri, content);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CreatedCard>(responseBody);
        }
    }
}