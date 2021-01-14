using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MvxElebris.Core.Helpers
{
    /// <summary>
    /// working on converting the timco implementation over to a mvvmcross rather tahn caliburn one
    /// not important for now, will work on later if I evewr need to lock down certain aspects of the project
    /// </summary>
    public class ApiHelper
    {
        public HttpClient ApiClient { get; set; }
        public ApiHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            string api = "get api address";
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task Authenticate(string username,string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),

                new KeyValuePair<string, string>("username", username),

                new KeyValuePair<string, string>("password", password)
            });

            using(HttpResponseMessage response = await ApiClient.PostAsync("/Token", data))
            {
                if(response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<string>();
                }
            }
        }

    }
}
