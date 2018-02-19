using System;
using System.Collections.Generic;

namespace Osrm.Client.V4.Models.Requests
{
    public class TableRequest
    {
        /// <summary>
        /// Location of the via point
        /// </summary>
        public Location[] Locations { get; set; }

        /// <summary>
        /// Source 	Location of the via point for rectangular matrix
        /// </summary>
        public Location[] SourceLocations { get; set; }

        /// <summary>
        /// Destination Locations of the via point for rectangular matrix
        /// </summary>
        public Location[] DestinationLocations { get; set; }

        public List<Tuple<string, string>> UrlParams
        {
            get
            {
                var urlParams = new List<Tuple<string, string>>();
                urlParams.AddRange(OsrmRequestBuilder.CreateLocationParams("loc", Locations));
                urlParams.AddRange(OsrmRequestBuilder.CreateLocationParams("src", SourceLocations));
                urlParams.AddRange(OsrmRequestBuilder.CreateLocationParams("dst", DestinationLocations));

                return urlParams;
            }
        }
    }
}