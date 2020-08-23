using Newtonsoft.Json;
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


            //GITHUB_HEAD_REF - e GITHUB_BASE_REF
            
            Console.Out.WriteLine($"GITHUB_HEAD_REF -> {Environment.GetEnvironmentVariable("GITHUB_HEAD_REF")}");
            Console.Out.WriteLine($"GITHUB_BASE_REF -> {Environment.GetEnvironmentVariable("GITHUB_BASE_REF")}");
            Console.Out.WriteLine($"BRANCH_REF -> {Environment.GetEnvironmentVariable("BRANCH_REF")}");

            

            
            Console.Out.WriteLine($"ARGS -> {string.Join(" ", args)}");

        }
    }
}
