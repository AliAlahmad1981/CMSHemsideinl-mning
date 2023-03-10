using System.Net.Http.Json;

namespace StrapiUI.Helpers
{
    public static class ApiServiceHelper
    {
        public static async ValueTask<TResult> PostJsonAsync<TMessage ,TResult>
            (this HttpClient httpClient,string path, TMessage message)
        {
            HttpResponseMessage httpResponse = await httpClient.PostAsJsonAsync(path, message);
            var result = await httpResponse.Content.ReadFromJsonAsync<TResult>();
            if (httpResponse.IsSuccessStatusCode && result != null)
            {
                return result;
            }
            else
            {
                throw new HttpRequestException(await httpResponse.Content.ReadAsStringAsync());
            }
        }
     
    }
}
