using MyWebApplication.Database;
using MyWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApplication.ModelGenerators
{
    public static class ModelGenerator
    {
        public static HospitalData GenerateHospitalDataModel(int? id)
        {
            if (id == null)
            {
                return null;
            }

            int hospitalId = id.GetValueOrDefault();
            DatabaseQueryHandler dbQueryFetcher = DatabaseQueryHandler.Instance;
            HospitalData hospitalData = new HospitalData(hospitalId);
            hospitalData.hospitalInfo = dbQueryFetcher.GetHospitalDetail(hospitalId);
            hospitalData.reviewEntryList = dbQueryFetcher.GetAllReviewEntriesByHospitalId(hospitalId).ToList();
            return hospitalData;
        }
    }
}