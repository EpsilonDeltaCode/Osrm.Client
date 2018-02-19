using System.Runtime.Serialization;

namespace Osrm.Client.V5.Models.Responses
{
    [DataContract]
    public class NearestResponse : BaseResponse
    {
        /// <summary>
        /// Array of Waypoint objects representing all waypoints in order:
        /// </summary>
        [DataMember(Name = "waypoints")]
        public Waypoint[] Waypoints { get; set; }
    }
}