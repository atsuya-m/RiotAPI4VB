using RiotAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestCS
{
    class Program
    {
        static void Main(string[] args)
        {
            RiotAPI.Client riotAPI = new RiotAPI.Client("SET_YOUR_API_KEY");
            Console.WriteLine(riotAPI.GetSummonersByName("SUMMONER_NAME").id);
        }
    }
}
