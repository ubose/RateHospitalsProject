using MyWebApplication.Database;
using MyWebApplication.ModelGenerators;
using MyWebApplication.Models;
using MyWebApplication.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyWebApplication.Controllers
{
    public class HospitalDataController : Controller
    {

        private DatabaseQueryHandler DbQueryHandler;
        // GET: HospitalData

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            this.DbQueryHandler = DatabaseQueryHandler.Instance;
        }
        
        public ActionResult Overview(int? id)
        {
            if (id == null)
            {
                return View("Error", null);
            }
            
            var model = ModelGenerator.GenerateHospitalDataModel(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Overview(ReviewInformation reviewInformation)
        {
            if (reviewInformation == null || reviewInformation.userName == null)
            {
                return View("Error", null);
            }
            
            int id = reviewInformation.hospitalId;
            ReviewEntry review = CreateReviewEntry(reviewInformation);
            if (review != null)
            {
                this.DbQueryHandler.AddReviewEntry(review);                    
            }

            ModelState.Clear();
            var model = ModelGenerator.GenerateHospitalDataModel(id);
            return View(model);
        }

        private ReviewEntry CreateReviewEntry(ReviewInformation reviewInformation)
        {
            ReviewEntry reviewEntry = new ReviewEntry
            {
                userId = reviewInformation.userName + reviewInformation.hospitalId.ToString(),
                userName = reviewInformation.userName,
                userRating = reviewInformation.Rating,
                userFeedback = reviewInformation.userFeedback,
                hospitalId = reviewInformation.hospitalId,
                isValid = true
            };

            return reviewEntry;
        }
    }
}