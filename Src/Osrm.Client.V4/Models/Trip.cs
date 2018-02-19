using System.Runtime.Serialization;
using Osrm.Client.V4.Models.Responses;

namespace Osrm.Client.V4.Models
{
    [DataContract]
    public class Trip : ViarouteResponse
    {
        /// <summary>
        /// permuation[i] gives the position in the trip of the i-th input coordinate.
        /// </summary>
        [DataMember(Name = "permutation")]
        public int[] Permutation { get; set; }
    }
}