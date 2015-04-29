using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebApplication.Models.DbModels
{
    public class ReviewEntry
    {
        [Required]
        public int id { get; set; }

        public string userId { get; set; }

        public string userName { get; set; }

        public string userFeedback { get; set; }

        public int userRating { get; set; }

        public int hospitalId { get; set; }

        public string DateTime { get; set; }

        public int userAge { get; set; }

        public string userLocation { get; set; }

        public bool isValid { get; set; }
    }
}