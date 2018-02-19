using System.Runtime.Serialization;

namespace Osrm.Client.V4.Models.Responses
{
    [DataContract]
    public class MatchResponse : OsrmBaseResponse
    {
        /// <summary>
        /// Geometry of the route compressed as polyline, but with 6 decimals.
        /// </summary>
        [DataMember(Name = "matchings")]
        public Matching[] Matchings { get; set; }
    }
}