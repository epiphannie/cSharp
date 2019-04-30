using System;
using Newtonsoft.Json;

namespace SoccerStats
{
    public class RootObject
    {
        public Player[] Player { get; set; }
    }

    public class Player
    {
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        public int Id { get; set; }

        [JsonProperty(PropertyName = "Points_per_game")]
        public double PointsPerGame { get; set; }

        [JsonProperty(PropertyName = "Second_name")]
        public string SecondName { get; set; }

        [JsonProperty(PropertyName = "Team_name")]
        public string TeamName{ get; set; }


    }
}
