using System.Net.Http.Json;

namespace USS.Base.Service
{
    public class BaseService<T>
    {
        protected readonly HttpClient http;
        private readonly string baseUrl;
        public BaseService(HttpClient httpClient)
        {
            http = httpClient;
            baseUrl = typeof(T).Name;
        }

        public async Task<List<T>> AllAsync()
        {
            return await http.GetFromJsonAsync<List<T>>(baseUrl);
        }

        public async Task<bool> InsertAsync(T data)
        {
            var result = await http.PostAsJsonAsync<T>(baseUrl, data);

            return true;
        }

        public async Task<bool> UpdateAsync(T data)
        {
            var result = await http.PutAsJsonAsync<T>(baseUrl, data);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid Id)
        {
            var result = await http.DeleteAsync($"{baseUrl}/{Id}");
            return true;
        }
    }
}
