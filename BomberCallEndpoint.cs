using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Stresstest
{
    public static class BomberCallEndpoint
    {
        public static async Task<string> CallEndpointAsync(string endpoint)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(endpoint))
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
