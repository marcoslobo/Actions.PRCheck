﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Actions.PRCheck
{
    class Program
    {
        static async Task Main(string[] args)
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
                client.DefaultRequestHeaders.Add("User-Agent", "request");
                
                var content = await client.GetStringAsync("https://api.github.com/repos/prefeiturasp/SME-NovoSGP/pulls?state=open");
                var a = JsonConvert.DeserializeObject<List<GitHubModels>>(content);
            }

            Console.WriteLine("Hello World!");
        }
    }
}