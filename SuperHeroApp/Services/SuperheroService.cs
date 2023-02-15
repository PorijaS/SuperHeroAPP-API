using SuperHeroApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Android.Provider.SyncStateContract;

namespace SuperHeroApp.Services
{
    public static class SuperheroService
    {
        static string Baseurl = DeviceInfo.Platform == DevicePlatform.Android ?
                                            "http://10.0.2.2:7075" : "http://localhost:7075";

        static HttpClient _client;
        static JsonSerializerOptions _serializerOptions;

        public static List<SuperHero> Items { get; set; }

        static SuperheroService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(Baseurl)
            };
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public static async Task<List<SuperHero>> RefreshDataAsync()
        {
            Items = new List<SuperHero>();

            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty))
        }
    }
}
