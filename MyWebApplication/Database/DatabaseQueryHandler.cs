using MyWebApplication.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace MyWebApplication.Database
{
    public sealed class DatabaseQueryHandler
    {
        static readonly DatabaseQueryHandler DatabaseQueryFetcherInstance = new DatabaseQueryHandler();

        public static DatabaseQueryHandler Instance
        {
            get
            {
                return DatabaseQueryFetcherInstance;
            }
        }

        DatabaseQueryHandler()
        {
            //do nothing as of now
        }

        public List<HospitalDetails> GetAllHospitalDetailsEntries()
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.HospitalDetails.ToList();
            }
        }

        public HospitalDetails GetHospitalDetail(int id)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.HospitalDetails.Find(id);
            }            
        }

        public void AddHospitalDetail(HospitalDetails hospitalDetails)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                db.HospitalDetails.Add(hospitalDetails);
                db.SaveChanges();
            }
        }

        public bool DeleteHospitalDetail(int id)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                HospitalDetails hospitalDetails = db.HospitalDetails.Find(id);
                if (hospitalDetails == null)
                {
                    return false;
                }

                db.HospitalDetails.Remove(hospitalDetails);
                db.SaveChanges();
                return true;
            }
        }

        public bool ModifyHospitalDetail(int id, HospitalDetails hospitalDetails)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                db.Entry(hospitalDetails).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HospitalDetailsExists(id))
                    {
                        return false;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

        public List<HospitalDetails> GetEntriesMatchedByName(string searchText)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.HospitalDetails.Where(x => x.Name.Contains(searchText)).ToList();
            }            
        }

        public IEnumerable<HospitalDetails> GetEntriesMatchedByCity(string searchText)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.HospitalDetails.Where(x => x.City.Contains(searchText)).ToList();
            }
        }

        public IEnumerable<HospitalDetails> GetEntriesMatchedByState(string searchText)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.HospitalDetails.Where(x => x.State.Contains(searchText)).ToList();
            }
        }

        public IEnumerable<ReviewEntry> GetAllReviewEntries()
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.ReviewEntries.ToList();
            }
        }

        public IEnumerable<ReviewEntry> GetAllValidReviewEntries()
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.ReviewEntries.Where(x => x.isValid == true).ToList();
            }
        }

        public IEnumerable<ReviewEntry> GetRecentNReviewEntries(int n)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.ReviewEntries.OrderByDescending(x => x.DateTime).Take(n);
            }
        }

        public IEnumerable<ReviewEntry> GetRecentNReviewEntries(int n, int hospitalId)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.ReviewEntries.OrderByDescending(x => x.DateTime).Where(x => x.hospitalId == hospitalId).Take(n);
            }
        }

        public IEnumerable<ReviewEntry> GetReviewEntriesSinceDate(DateTime dateTime)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                //update database to have date time as type DateTime, and then compare
                return db.ReviewEntries.Where(x => x.DateTime.CompareTo(dateTime) >= 0).ToList();
            }
        }

        public int GetMostRatedHospitalId()
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                //see group by cluase and update this, else do by foreach
                return 0;
            }
        }

        public IEnumerable<ReviewEntry> GetAllReviewEntriesByHospitalId(int id)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.ReviewEntries.Where(x => x.hospitalId == id).ToList();
            }
        }

        public IEnumerable<ReviewEntry> GetRatingSpecificReviewEntries(int lowestRating)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.ReviewEntries.Where(x => x.userRating > lowestRating).ToList();
            }
        }

        public IEnumerable<ReviewEntry> GetRatingSpecificReviewEntries(int lowestRating, int hospitalId)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.ReviewEntries.Where(x => x.userRating > lowestRating && x.hospitalId == hospitalId).ToList();
            }
        }

        public void AddReviewEntry(ReviewEntry reviewEntry)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                db.ReviewEntries.Add(reviewEntry);
                db.SaveChanges();
            }
        }

        public void Dispose(bool disposing)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
        }

        protected bool HospitalDetailsExists(int id)
        {
            using (MyWebApplicationContext db = new MyWebApplicationContext())
            {
                return db.HospitalDetails.Count(e => e.id == id) > 0;
            }
        }



    }
}