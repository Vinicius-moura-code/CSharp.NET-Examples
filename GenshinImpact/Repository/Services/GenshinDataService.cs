using GenshinImpact.Models;
using GenshinImpact.Repository.Services.Interfaces;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GenshinImpact.Repository.Services
{
    public class GenshinDataService
    {
        HttpClient cliente = new HttpClient();
        public GenshinDataService()
        {
            //cliente.BaseAddress = new Uri("https://genshinlist.com/");
            //cliente.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));


        }

        public  async Task<Characters> getCharactersAsync()
        {
            var myCharacter = RestService.For<IGenshinCharacter>("https://genshinlist.com/api");

            Characters chars = new Characters();
            //HttpResponseMessage getCharacters = await cliente.GetAsync("api/characters");
            try
            {
                //Characters item;

                
                
                chars = await myCharacter.getCharacter();

                //JsonConvert.DeserializeObject(item);

                return chars;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Weapons>> getWeaponsAsync()
        {

            HttpResponseMessage getWeaponsAsync = await cliente.GetAsync("api/weapons");
            try
            {
                if (getWeaponsAsync.IsSuccessStatusCode)
                {
                    var weapons = await getWeaponsAsync.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Weapons>>(weapons);
                }
                return new List<Weapons>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Artifacts>> getArtifactsAsync()
        {

            HttpResponseMessage getArtifactsAsync = await cliente.GetAsync("api/artifacts");
            try
            {
                if (getArtifactsAsync.IsSuccessStatusCode)
                {
                    var artifacts = await getArtifactsAsync.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Artifacts>>(artifacts);
                }
                return new List<Artifacts>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //const data = await 

    }
}
