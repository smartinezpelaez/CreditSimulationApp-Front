using CreditSimulationApp.DAL.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace CreditSimulationApp.WEB
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7221/") };
        }

        // Método para obtener todos los clientes
        public async Task<List<ClienteDTO>> GetClientesAsync()
        {
            var response = await _httpClient.GetAsync("api/Cliente");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<ClienteDTO>>(jsonResponse);
        }

        // Método para obtener un cliente por su ID
        public async Task<ClienteDTO> GetClienteByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/Cliente/{id}");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClienteDTO>(jsonResponse);
        }

        // Método para crear un nuevo cliente
        public async Task<ClienteDTO> CreateClienteAsync(ClienteDTO cliente)
        {
            var content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Cliente", content);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ClienteDTO>(jsonResponse);
        }

        // Método para eliminar un cliente por su ID
        public async Task<bool> DeleteClienteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Cliente/{id}");
            return response.IsSuccessStatusCode;
        }

        // Método para obtener todos los créditos
        public async Task<List<CreditoDTO>> GetCreditosAsync()
        {
            var response = await _httpClient.GetAsync("api/Credito");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<CreditoDTO>>(jsonResponse);
        }

        // Método para obtener un crédito por su ID
        public async Task<CreditoDTO> GetCreditoByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/Credito/{id}");
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CreditoDTO>(jsonResponse);
        }

        // Método para crear un nuevo crédito
        public async Task<CreditoDTO> CreateCreditoAsync(CreditoDTO credito)
        {
            var content = new StringContent(JsonConvert.SerializeObject(credito), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Credito", content);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CreditoDTO>(jsonResponse);
        }

        // Método para eliminar un crédito por su ID
        public async Task<bool> DeleteCreditoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Credito/{id}");
            return response.IsSuccessStatusCode;
        }
    }

}
