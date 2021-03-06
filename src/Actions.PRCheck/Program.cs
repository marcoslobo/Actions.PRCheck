﻿using Actions.PRCheck.Context;
using Newtonsoft.Json;
using System;
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


            //Console.Out.WriteLine($"BRANCH_REF -> {Environment.GetEnvironmentVariable("BRANCH_REF")}");


            //Console.Out.WriteLine($"GITHUB_HEAD_REF -> {Environment.GetEnvironmentVariable("GITHUB_HEAD_REF")}");
            //Console.Out.WriteLine($"GITHUB_BASE_REF -> {Environment.GetEnvironmentVariable("GITHUB_BASE_REF")}");
            //Console.Out.WriteLine($"GITHUB_EVENT_PATH -> {Environment.GetEnvironmentVariable("GITHUB_EVENT_PATH")}");


            //var json = "";

            //using (StreamReader r = new StreamReader(Environment.GetEnvironmentVariable("GITHUB_EVENT_PATH")))
            //{
            //    json = r.ReadToEnd();                
            //}

            var gitHubContext = JsonConvert.DeserializeObject<GitHubContext>(Environment.GetEnvironmentVariable("GITHUB_CONTEXT"));


            if (gitHubContext.HeadRef.ToLower() == "release")
                Console.Out.WriteLine($"Branch Release está OK para merge em Master");
            else
            {
                Console.Out.WriteLine($"Verificando se este Pull Request possui TAG de verificação AB#NUMERO-DA-TASK");

                var tag = "";
                var msgBody = gitHubContext.Event.PullRequest.Body;
                
                Console.Out.WriteLine(msgBody);

                if (msgBody.Contains("AB#"))
                {
                    
                    var inicio = msgBody.IndexOf("AB#");
                    msgBody = msgBody.Remove(0, inicio);

                    if (msgBody.Contains(" "))
                    {
                        var espaco = msgBody.IndexOf(" ");
                        msgBody = msgBody.Remove(espaco);
                    }

                    tag = msgBody;
                }

                if (string.IsNullOrEmpty(tag))
                    throw new Exception("Não foi localizado a tag AB#NUMERO-DA-TASK no Pull Request");
                else                
                {
                    Console.Out.WriteLine($"TAG para buscar nos Pull Requests para Developement e Release {tag}");                    
                }
                
                
            }



            //var branchFrom = githubAction.Ref.Replace("refs/heads/", "");

            //Console.Out.WriteLine($"From -> {branchFrom}");

            //if (branchFrom.ToLower() == "release")
            //    Console.Out.WriteLine($"Branch Release está OK para merge em Master");
            //else
            //{
            //    var tag = "";
            //    Console.Out.WriteLine($"Verificando se este Push possui TAG de verificação AB#NUMERO-DA-TASK");


            //    foreach (var commit in githubAction.Commits)
            //    {
            //        if (string.IsNullOrEmpty(tag) && commit.Message.Contains("AB#"))
            //        {
            //            var msg = commit.Message;
            //            var inicio = commit.Message.IndexOf("AB#");
            //            msg = msg.Remove(0, inicio);

            //            var espaco = msg.IndexOf(" ");
            //            tag = msg.Remove(espaco);                        
            //        }
            //    }

            //    if (string.IsNullOrEmpty(tag))
            //        throw new Exception("Não foi localizado a tag AB#NUMERO-DA-TASK no Pull Request");


            //Console.Out.WriteLine($"-- --");


            //Console.Out.WriteLine($"Verificando se a branch");
            //Console.Out.WriteLine($"Master possui Pull Request aberto para as branches Development e Release com a tag ");

            //Console.Out.WriteLine($"-- --");

        }





        //Console.Out.WriteLine($"ARGS -> {string.Join(" ", args)}");

    }
}

