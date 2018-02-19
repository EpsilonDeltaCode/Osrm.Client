using System;
using System.Collections.Generic;

namespace Osrm.Client.V4.Models.Requests
{
    public class NearestRequest
    {
        /// <summary>
        /// Location of the node
        /// </summary>
        public Location Location { get; set; }

        public List<Tuple<string, string>> UrlParams
        {
            get
            {
                var urlParams = new List<Tuple<string, string>>();
                urlParams.AddRange(OsrmRequestBuilder.CreateLocationParams("loc", new Location[] { Location }));

                return urlParams;
            }
        }
    }
}