using MyWebApplication.Database;
using MyWebApplication.ModelGenerators;
using MyWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApplication.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Results(string searchText)
        {
            //HospitalInfoList hospitalInfoList = new HospitalInfoList();
            //HospitalInfo hospitalInfo = new HospitalInfo("Pearless", "Good hospital", "03324256738", "Highland park");
            //hospitalInfoList.HospitalEntryList.Add(hospitalInfo);
            DatabaseQueryHandler dbQueryFetcher = DatabaseQueryHandler.Instance;
            var results = dbQueryFetcher.GetEntriesMatchedByName(searchText);
            return View(results);
        }
    }
}