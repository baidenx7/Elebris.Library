using CaliburnWPFApp.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnWPFApp.Library.Api
{

    public class CharacterStatEndpoint : ICharacterStatEndpoint
    {
        private IApiHelper _apiHelper;
        public CharacterStatEndpoint(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        public async Task PostStat(StagedCharacterStatModel statModel)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Stat", statModel))
            {
                if (response.IsSuccessStatusCode)
                {
                    //TODO Log successful call
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        public async Task<List<StagedCharacterStatModel>> GetAll()
        {

            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Stat"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<StagedCharacterStatModel>>();
                    return result;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
