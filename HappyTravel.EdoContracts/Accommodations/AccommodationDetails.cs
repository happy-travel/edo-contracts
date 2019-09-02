﻿using System.Collections.Generic;
using System.Runtime.InteropServices;
using HappyTravel.EdoContracts.Accommodations.Enums;
using HappyTravel.EdoContracts.Accommodations.Internals;
using Newtonsoft.Json;

namespace HappyTravel.EdoContracts.Accommodations
{
    [StructLayout(LayoutKind.Auto)]
    public readonly struct AccommodationDetails
    {
        [JsonConstructor]
        public AccommodationDetails(string id, string name, Dictionary<string, bool> accommodationAmenities, Dictionary<string, string> additionalInfo,
            string category, in ContactInfo contacts, string description, in LocationInfo location, List<Picture> pictures, AccommodationRatings rating,
            Dictionary<string, bool> roomAmenities, in ScheduleInfo schedule, List<TextualDescription> textualDescriptions)
        {
            Id = id;
            AccommodationAmenities = accommodationAmenities ?? new Dictionary<string, bool>(0);
            AdditionalInfo = additionalInfo ?? new Dictionary<string, string>(0);
            Category = category;
            Contacts = contacts;
            Description = description;
            Rating = rating;
            Location = location;
            Name = name;
            Pictures = pictures ?? new List<Picture>(0);
            RoomAmenities = roomAmenities ?? new Dictionary<string, bool>(0);
            Schedule = schedule;
            TextualDescriptions = textualDescriptions ?? new List<TextualDescription>(0);
        }


        /// <summary>
        ///     Accommodation ID
        /// </summary>
        public string Id { get; }

        /// <summary>
        ///     Accommodation name
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Accommodation category
        /// </summary>
        public string Category { get; }

        /// <summary>
        ///     Contact info
        /// </summary>
        public ContactInfo Contacts { get; }

        /// <summary>
        ///     Description of an accommodation style
        /// </summary>
        public string Description { get; }

        /// <summary>
        ///     Location info
        /// </summary>
        public LocationInfo Location { get; }

        /// <summary>
        ///     Accommodation pictures and their descriptions
        /// </summary>
        public List<Picture> Pictures { get; }

        /// <summary>
        ///     Accommodation rating
        /// </summary>
        public AccommodationRatings Rating { get; }

        /// <summary>
        ///     Schedule of accommodation services
        /// </summary>
        public ScheduleInfo Schedule { get; }

        /// <summary>
        ///     Textual descriptions of an accommodation and its zones
        /// </summary>
        public List<TextualDescription> TextualDescriptions { get; }

        /// <summary>
        ///     Dictionary of amenities available in an accommodation
        /// </summary>
        public Dictionary<string, bool> AccommodationAmenities { get; }

        /// <summary>
        ///     Dictionary of amenities available in rooms
        /// </summary>
        public Dictionary<string, bool> RoomAmenities { get; }

        /// <summary>
        ///     Dictionary of all other accommodation stats
        /// </summary>
        public Dictionary<string, string> AdditionalInfo { get; }
    }
}
