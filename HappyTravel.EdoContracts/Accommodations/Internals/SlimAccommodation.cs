﻿using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations.Internals
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct SlimAccommodation
    {
        [JsonConstructor]
        public SlimAccommodation(string id, in SlimLocationInfo location, string name, in ImageInfo photo, AccommodationRatings rating,
            PropertyTypes propertyType,
            string? htId = null, string? hotelChain = null)
        {
            Id = id;
            Location = location;
            Name = name;
            Photo = photo;
            Rating = rating;
            PropertyType = propertyType;
            HtId = htId ?? string.Empty;
            HotelChain = hotelChain;
        }


        /// <summary>
        ///     The accommodation ID.
        /// </summary>
        public string Id { get; }

        /// <summary>
        ///     The accommodation location description.
        /// </summary>
        public SlimLocationInfo Location { get; }

        /// <summary>
        ///     The accommodation name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     The front photo of an accommodation.
        /// </summary>
        public ImageInfo Photo { get; }

        /// <summary>
        ///     The rating of an accommodation.
        /// </summary>
        public AccommodationRatings Rating { get; }

        /// <summary>
        ///     The type of an accommodation.
        /// </summary>
        public PropertyTypes PropertyType { get; }

        /// <summary>
        ///     The Happytravel.com correlation ID.
        /// </summary>
        public string HtId { get; }

        /// <summary>
        ///     The name of a hotel chain which an accommodation belongs.
        /// </summary>
        public string? HotelChain { get; }


        public override bool Equals(object? obj) => obj is SlimAccommodation other && Equals(other);


        public bool Equals(in SlimAccommodation other)
            => (Id, Location, Name, Photo, Rating, PropertyType)
                .Equals((other.Id, other.Location, other.Name, other.Photo, other.Rating, other.PropertyType));


        public override int GetHashCode()
            => (Id, Location, Name, Photo, Rating)
                .GetHashCode();
    }
}