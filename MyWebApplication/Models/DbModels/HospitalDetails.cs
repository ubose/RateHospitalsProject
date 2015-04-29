using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebApplication.Models.DbModels
{
    public class HospitalDetails
    {
        /// <summary>
        /// The primary Id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Name of the Hospital
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description about the hospital (optional)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The contact info of the hospital
        /// </summary>
        public string ContactInfo { get; set; }

        /// <summary>
        /// The rank of the hospital
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// The website link of the hospital if any
        /// </summary>
        public string WebsiteLink { get; set; }

        /// <summary>
        /// Hospital address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The city where the hospital belongs
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state where the hospital belongs.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The country to which the hospital belongs
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The type of the hospital,
        /// like government/private undertaking
        /// </summary>
        public string Type { get; set; }



    }
}