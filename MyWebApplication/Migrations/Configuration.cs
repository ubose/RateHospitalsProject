namespace MyWebApplication.Migrations
{
    using MyWebApplication.Models.DbModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyWebApplication.Models.DbModels.MyWebApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyWebApplication.Models.DbModels.MyWebApplicationContext context)
        {
            // This method will be called after migrating to the latest version.
            // context.Database.ExecuteSqlCommand("DELETE FROM HospitalDetails");
            // context.Database.ExecuteSqlCommand("DELETE FROM ReviewEntries");

            context.HospitalDetails.AddOrUpdate(x => x.id,
            new HospitalDetails
            {
                id = 1,
                Name = "Ruby General Hospital",
                Description = "Ruby General Hospital has a very well experienced and accomplished team of medical practitioners, technicians, nurses and other administrative staff. Ruby General Hospital has around 175 renowned Sr. Consultants of different specialties and around 50 In-house Doctors who are always available. Our Out Patient Services in 42 multi-specialties are available from 8 am to 8 pm.(Monday - Saturday) and 8 am-2 pm (on Sundays )",
                ContactInfo = "+(91)-(33)-39871800",
                WebsiteLink = "http://www.rubyhospital.com/",
                City = "Kolkata",
                State = "West Bengal",
                Country = "India",
                Rank = "10",
                Type = "private"
            },
            new HospitalDetails
            {
                id = 2,
                Name = "Desun Hospital",
                Description = "Within 3 years of opening DESUN Hospital has achieved the prestigious National Accreditation Board for Hospitals (NABH) Accreditation from the Government of India for its quality medical treatment and hospital services. Since the setting up of NABH in the year 2006, not even 100 hospitals have been able to achieve these tough quality standards and get the accreditation.",
                ContactInfo = "(+91) 86977 21124",
                WebsiteLink = "http://www.desunhospital.com/",
                City = "Kolkata",
                State = "West Bengal",
                Country = "India",
                Rank = "5",
                Type = "private"
            },
            new HospitalDetails
            {
                id = 3,
                Name = "AMRI Hospital",
                Description = "The facility is fully equipped to dispense services in neurosciences, oncology, orthopaedics, trauma care, cardiology and cardiac surgery. AMRI Hospitals is the first in Eastern India to provide comprehensive cancer treatment through well qualified, reputed and experienced team of Cancer specialists, technicians and nurses. Now at AMRI Saltlake 210 beds are available to expand the facility of heath care.",
                ContactInfo = "(+91)-33-6614 7700",
                WebsiteLink = "http://www.amrihospital.com/",
                City = "Kolkata",
                State = "West Bengal",
                Country = "India",
                Rank = "20",
                Type = "private"
            },
            new HospitalDetails
            {
                id = 4,
                Name = "Apollo Hospital",
                Description = "A 610-bedded multispecialty tertiary care hospital – Apollo Gleneagles Hospitals Kolkata, is a perfect blend of technological excellence, complete infrastructure, competent care and heartfelt hospitality - this is how the people, whom we have been fortunate to serve, define the hospital.",
                ContactInfo = "+91 33 2320 3040",
                WebsiteLink = "http://www.apollogleneagles.in/",
                City = "Kolkata",
                State = "West Bengal",
                Country = "India",
                Rank = "2",
                Type = "private"
            },
            new HospitalDetails
            {
                id = 5,
                Name = "CMRI Hospital",
                Description = "The Calcutta Medical Research Institute (CMRI) is a part of the CK Birla Group. With a heritage spanning more than 45 years, it is recognised as one of the most trusted multi-super speciality tertiary care hospitals in Eastern India. Apart from treating patients from India, CMRI also caters to patients from countries like Nepal, Bangladesh, Bhutan and Myanmar.",
                ContactInfo = "+91 33 30903030",
                WebsiteLink = "http://www.cmri.in/",
                City = "Kolkata",
                State = "West Bengal",
                Country = "India",
                Rank = "4",
                Type = "private"
            });
        }
    }
}
