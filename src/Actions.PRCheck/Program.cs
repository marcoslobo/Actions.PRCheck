using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Actions.PRCheck
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //using (var client = new HttpClient())
            //{
            //    client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            //    client.DefaultRequestHeaders.Add("User-Agent", "request");

            //    var content = await client.GetStringAsync("https://api.github.com/repos/prefeiturasp/SME-NovoSGP/pulls?state=open");
            //    var a = JsonConvert.DeserializeObject<List<GitHubModels>>(content);
            //}


            //GITHUB_HEAD_REF - e GITHUB_BASE_REF

            //Console.Out.WriteLine($"GITHUB_HEAD_REF -> {Environment.GetEnvironmentVariable("GITHUB_HEAD_REF")}");
            //Console.Out.WriteLine($"GITHUB_BASE_REF -> {Environment.GetEnvironmentVariable("GITHUB_BASE_REF")}");
            //Console.Out.WriteLine($"BRANCH_REF -> {Environment.GetEnvironmentVariable("BRANCH_REF")}");
            //Console.Out.WriteLine($"GITHUB_EVENT_PATH -> {Environment.GetEnvironmentVariable("GITHUB_EVENT_PATH")}");


            using (StreamReader r = new StreamReader(Environment.GetEnvironmentVariable("GITHUB_EVENT_PATH")))
            {
                string json = r.ReadToEnd();

                Console.Out.WriteLine(json);

                var a = JsonConvert.DeserializeObject<GitHubActionModelInside>(json);


            }




            //Console.Out.WriteLine($"ARGS -> {string.Join(" ", args)}");

        }
    }
}
