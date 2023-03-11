using System.Collections.Concurrent;
using Umbraco.Models;

namespace Umbraco.Services
{
    public class CurrencyService
    {


        public async ValueTask<Currency> GetAllCurrenciesAsync()
        {// f8anUVQRcqa5EME30o43EbmV4d1hjiH8tsdstjj
            using (HttpClient httpClient = new HttpClient())
            {
                // await httpClient.GetFromJsonAsync("");
            }
            return await ValueTask.FromResult(new Currency());
        }
    }
}
