using static System.Net.WebRequestMethods;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text.Json;
using BlazorServerAPI.Models;
using System.Reflection.Metadata.Ecma335;

namespace BlazorServerAPI.Helpers
{
    public class testValue
    {
        public int returnSum(int x, int i) { return x + i; }
        // static int testNumber = 1;


    }

    public class ApiResponseTest
    {
        static public async Task<string> PrintWebApiResponse()
        {
            HttpClient Http = new HttpClient();

            var response = await Http.GetStringAsync("https://www.boredapi.com/api/activity/");
            Models.Data? factData = JsonSerializer.Deserialize<Models.Data>(response);
            Console.WriteLine(response);
            Console.WriteLine(factData.activity);

            return factData.activity;
        }
    }
}
