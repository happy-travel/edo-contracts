﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HappyTravel.EdoContracts.GeoData.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationTypes
    {
        Unknown = 0,
        Destination = 1,
        Accommodation = 2,
        Landmark = 3,
        Location = 4
    }
}
