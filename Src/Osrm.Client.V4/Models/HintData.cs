﻿using System.Linq;
using System.Runtime.Serialization;

namespace Osrm.Client.V4.Models
{
    [DataContract]
    public class HintData
    {
        /// <summary>
        /// To be passed with the next requests
        /// </summary>
        [DataMember(Name = "checksum")]
        public long Checksum { get; set; }

        /// <summary>
        /// Array of hints for each vis point append with use the hint parameter to pass it after the corresponding loc
        /// </summary>
        [DataMember(Name = "locations")]
        public string[] LocationsArray { get; set; }

        /// <summary>
        /// array of hints for each vis point append with use the hint parameter to pass it after the corresponding loc
        /// </summary>
        public Location[][] Locations
        {
            get
            {
                if (LocationsArray == null)
                {
                    return new Location[0][];
                }

                return LocationsArray.Select(x => Enumerable.ToArray<Location>(OsrmPolylineConverter.Decode(x))).ToArray();
            }
        }
    }
}