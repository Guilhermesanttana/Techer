using System;
using System.Collections.Generic;
using System.Net.Http;

namespace HttpClientDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:44343/api/");

                var resp = httpClient.GetAsync("values");
                resp.Wait();

                var result = resp.Result;

                if (result.IsSuccessStatusCode)
                {
                    var getContent = result.Content.ReadAsAsync<IEnumerable<string>>();
                    getContent.Wait();

                    var getContentResp = getContent.Result;
                    foreach (var a in getContentResp)
                    {
                        Console.WriteLine(a);
                    }

                    
                }

                Console.ReadLine();
            }
        }
    }
}
