using MyWebApplication.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApplication.Models
{
    public class HospitalData
    {
        public HospitalData()
        {
            reviewInfo = new ReviewInformation();
        }

        public HospitalData(int id)
        {
            reviewInfo = new ReviewInformation(id);
        }

        public HospitalDetails hospitalInfo { get; set; }

        public ReviewInformation reviewInfo { get; set; }

        public List<ReviewEntry> reviewEntryList { get; set; }

    }
}