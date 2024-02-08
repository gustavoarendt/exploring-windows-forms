using System.Net.Http;
using System.Threading.Tasks;

namespace Utils
{
    public static class Network
    {
        public static async Task<string> GetAddressJsonViaCep(string cep)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
