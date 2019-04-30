using System;
using System.Collections.Generic;
using System.Net;

namespace SoccerStats
{
    //make class for return results using samplejson return (NewsResults)

    public static List<NewsResults> GetNewsForPlayer(string playerName)
    {
        var results = new List<NewsResult>;
        var webClient = new WebClient();
        webClient.Headers.Add(//HeaderName from docs, APIkey, both strings)
        byte[] searchResults = webClient.DownloadData(string.Format(//URL for API, replace text after "q=" with {0}, then pass player name into", playerName)
            ;

        var serializer = new JsonSerializer();
        using (var stream = new MemoryStream(searchResults))
        using (var reader = new StreamReader(stream))
        using (var jsonReader = new JsonTextReader(reader))
        {
            results = serializer.Deserialize<NewsSearch>(jsonReader).NewsResults;
        }
        return results;
    }

    //in main
    Console.WriteLine(GetNewsForPlayer);

        foreach(var player in topTenPlayers)
            {
                List<NewsResult> newsResults = GetNewsForPlayer(string.Format("{0} {1}", Player.FirstName, Player.LastName));
    foreach(var result in newsResults)
        {
            Console.WriteLIne(string.Format("Date: {0:f}, Headline: {1}, Summary: {2} \r \n", result.DatePublished, result.Headline, result.Summary);
            Console.ReadKey();
        }
            }
}
