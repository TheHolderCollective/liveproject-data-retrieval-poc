using Gtc.Models.FederalRegister;
using Gtc.Utils;
using System.Text.Json;

namespace Gtc.Services
{
    public class FederalRegisterService
    {
        public async Task<Response?> GetResponseAsync(string urlEndpoint)
        {
            var responseBody = await this.GetResponseJsonAsync(urlEndpoint);
            var serializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = new SnakeCaseNamingPolicy(),
                PropertyNameCaseInsensitive = true
            };
            var response = responseBody != null ? JsonSerializer.Deserialize<Response>(responseBody, options: serializerOptions) : null;
            return response;
        }

        public virtual async Task<string?> GetResponseJsonAsync(string urlEndPoint)
        {

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(urlEndPoint);
            var responseBody = await response.Content.ReadAsStringAsync();

            return responseBody;
        }
    }
}
