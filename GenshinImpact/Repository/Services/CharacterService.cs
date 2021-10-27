using GenshinImpact.Models;
using GenshinImpact.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GenshinImpact.Repository.Services.Interfaces
{
    public class CharacterService : GenshinDataService
    {
        public async Task<List<CharacterViewModel>> getCharactersAsync()
        {
            HttpResponseMessage response = await cliente.GetAsync("characters");
            try
            {
                //Characters item;
                if (response.IsSuccessStatusCode)
                {
                    string dados = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<List<CharacterViewModel>>(dados);
                }
                return new List<CharacterViewModel>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}