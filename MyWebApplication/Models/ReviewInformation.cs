using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApplication.Models
{
    public class ReviewInformation
    {
        public ReviewInformation()
        {

        }

        public ReviewInformation(int id)
        {
            hospitalId = id;
        }

        public int hospitalId { get; set; }
        public string userName { get; set; }

        public string userFeedback { get; set; }

        public int Rating { get; set; }
    }
}