using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MyWebApplication.Models.DbModels;
using MyWebApplication.Database;

namespace MyWebApplication.Controllers.ApiControllers
{
    public class HospitalDetailsController : ApiController
    {
        DatabaseQueryHandler dbQueryFetcher = DatabaseQueryHandler.Instance;

        // GET: api/HospitalDetails
        public List<HospitalDetails> GetHospitalDetails()
        {
            return dbQueryFetcher.GetAllHospitalDetailsEntries();
        }

        // GET: api/HospitalDetails/5
        [ResponseType(typeof(HospitalDetails))]
        public IHttpActionResult GetHospitalDetails(int id)
        {
            HospitalDetails hospitalDetails = dbQueryFetcher.GetHospitalDetail(id);
            if (hospitalDetails == null)
            {
                return NotFound();
            }

            return Ok(hospitalDetails);
        }

        // PUT: api/HospitalDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHospitalDetails(int id, HospitalDetails hospitalDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hospitalDetails.id)
            {
                return BadRequest();
            }

            dbQueryFetcher.ModifyHospitalDetail(id, hospitalDetails);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/HospitalDetails
        [ResponseType(typeof(HospitalDetails))]
        public IHttpActionResult PostHospitalDetails(HospitalDetails hospitalDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            dbQueryFetcher.AddHospitalDetail(hospitalDetails);
            return CreatedAtRoute("DefaultApi", new { id = hospitalDetails.id }, hospitalDetails);
        }

        // DELETE: api/HospitalDetails/5
        [ResponseType(typeof(HospitalDetails))]
        public IHttpActionResult DeleteHospitalDetails(int id)
        {
            bool result = dbQueryFetcher.DeleteHospitalDetail(id);
            if (!result)
            {
                return NotFound();
            }

             return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            dbQueryFetcher.Dispose(disposing);
            base.Dispose(disposing);
        }
    }
}