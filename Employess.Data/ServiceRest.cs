using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Employess.Data
{
    public class ServiceRest : IServices
    {
        public async Task<ResponseServices> CallService(string Url)
        {
            HttpClient client = new HttpClient();
            ResponseServices result = new ResponseServices(); 
            try
            {
                client.Timeout = TimeSpan.FromMilliseconds(6000);
                var response = await client.GetAsync(Url);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    result.State = true;
                    result.Message = "OK";
                    result.Data = JsonConvert.DeserializeObject<List<Employe>>(data);
                }
                else
                {
                    result.State = false;
                    result.Message = response.RequestMessage.ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                result.State = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
