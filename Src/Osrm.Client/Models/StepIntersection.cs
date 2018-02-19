using System.Runtime.Serialization;
using Osrm.Client.Base;

namespace Osrm.Client.Models
{
    [DataContract]
    public class StepIntersection
    {
        [DataMember(Name = "out")]
        public int OutAngle { get; set; }

        [DataMember(Name = "in")]
        public int InAngle { get; set; }

        [DataMember(Name = "entry")]
        public bool[] Entries { get; set; }

        [DataMember(Name = "bearings")]
        public int[] Bearings { get; set; }

        [DataMember(Name = "location")]
        protected double[] LocationArr { get; set; }

        public Location Location
        {
            get
            {
                if (LocationArr == null)
                    return null;

                return new Location(LocationArr[1], LocationArr[0]);
            }
        }
    }
}