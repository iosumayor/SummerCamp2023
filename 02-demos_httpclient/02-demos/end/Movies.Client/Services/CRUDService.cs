using Movies.API.Models;
using Movies.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Client.Services
{
    public class CRUDService : IIntegrationService


    {
        private static HttpClient _hTtpClient = new HttpClient();


        public CRUDService()
        {

            _hTtpClient.BaseAddress = new Uri("http://www.boredapi.com");
        }
        public async Task Run()
        {

            await EjemploGet();
        
        }

        private async Task EjemploGet()
        {

            var response = await _hTtpClient.GetAsync("api/activity");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var bored = new BoredActivity();

           
            
            bored = JsonConvert.DeserializeObject<BoredActivity>(content);

            
        }
    }
}
