using CaliburnWPFApp.Library.Models;
using CaliburnWPFApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnWPFApp.Library.Api
{
    /// <summary>
    /// working on converting the timco implementation over to a mvvmcross rather tahn caliburn one
    /// not important for now, will work on later if I evewr need to lock down certain aspects of the project
    /// </summary>
    public class ApiHelper : IApiHelper
    {
        private HttpClient apiClient;
        private ILoggedInUserModel _loggedInUser;

        public ApiHelper(ILoggedInUserModel loggedInUser)
        {
            InitializeClient();
            _loggedInUser = loggedInUser;
        }

        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];
            apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri("");
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),

                new KeyValuePair<string, string>("username", username),

                new KeyValuePair<string, string>("password", password)
            });

            using (HttpResponseMessage response = await apiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task GetLoggedInUserInfo(string token)
        {

            apiClient.DefaultRequestHeaders.Clear();
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer { token }");


            using (HttpResponseMessage response = await apiClient.GetAsync("/api/User"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<LoggedInUserModel>();
                    _loggedInUser.CreatedDate = result.CreatedDate;
                    _loggedInUser.FirstName = result.FirstName;
                    _loggedInUser.LastName = result.LastName;
                    _loggedInUser.DisplayName = result.DisplayName;
                    _loggedInUser.EmailAddress = result.EmailAddress;
                    _loggedInUser.CreatedDate = result.Id;
                    _loggedInUser.CreatedDate = token;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
