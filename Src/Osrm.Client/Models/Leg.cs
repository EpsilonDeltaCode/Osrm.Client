﻿using System.Runtime.Serialization;

namespace Osrm.Client.Models
{
    [DataContract]
    public class RouteLeg
    {
        [DataMember(Name = "distance")]
        public double Distance { get; set; }

        [DataMember(Name = "duration")]
        public double Duration { get; set; }

        [DataMember(Name = "steps")]
        public RouteStep[] Steps { get; set; }

        [DataMember(Name = "summary")]
        public string Summary { get; set; }
    }
}