﻿using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct CancellationPolicy
    {
        [JsonConstructor]
        public CancellationPolicy(DateTime fromDate, double percentage)
        {
            FromDate = fromDate;
            Percentage = percentage;
        }


        public DateTime FromDate { get; }
        public double Percentage { get; }
        
        
        public bool Equals(CancellationPolicy other) => FromDate.Equals(other.FromDate) && Percentage.Equals(other.Percentage);


        public override bool Equals(object? obj) => obj is CancellationPolicy other && Equals(other);


        public override int GetHashCode() => HashCode.Combine(FromDate, Percentage);
    }
}
