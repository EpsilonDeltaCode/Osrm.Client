﻿namespace Osrm.Client.V4.Models
{
    public class Location //: System.Object
    {
        public Location()
        {
        }

        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Location p = obj as Location;
            if ((System.Object)p == null)
            {
                return false;
            }

            return (Latitude == p.Latitude) && (Longitude == p.Longitude);
        }

        public bool Equals(Location p)
        {
            if ((object)p == null)
            {
                return false;
            }

            return (Latitude == p.Latitude) && (Longitude == p.Longitude);
        }

        public override int GetHashCode()
        {
            return Latitude.GetHashCode() ^ Longitude.GetHashCode();
        }

        public static bool operator ==(Location a, Location b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.Latitude == b.Latitude && a.Longitude == b.Longitude;
        }

        public static bool operator !=(Location a, Location b)
        {
            return !(a == b);
        }
    }
}