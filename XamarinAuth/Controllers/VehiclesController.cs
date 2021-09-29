using Microsoft.AspNet.Identity;
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
using XamarinAuth.Models;

namespace XamarinAuth.Controllers
{
    [Authorize]
    public class VehiclesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: api/Vehicles
        [Route("api/Vehicles/GetVehiclesForCurrentUse")]
        public IQueryable<Vehicle> GetVehiclesForCurrentUse()
        {
            var userid = User.Identity.GetUserId();
            return db.Vehicles.Where(x=>x.UserId==userid);
        }
        [ResponseType(typeof(Vehicle))]
        public IQueryable<Vehicle> Search(string Value )
        {
            var userid = User.Identity.GetUserId();
            return db.Vehicles.Where(x => x.UserId == userid);
        }
        // GET: api/Vehicles
        public IQueryable<Vehicle> GetVehicles()
        {
            return db.Vehicles;
        }

        // GET: api/Vehicles/5
        [ResponseType(typeof(Vehicle))]
        public IHttpActionResult GetVehicle(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return Ok(vehicle);
        }

        // PUT: api/Vehicles/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVehicle(int id, Vehicle vehicle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vehicle.VehicleId)
            {
                return BadRequest();
            }
            var userid = User.Identity.GetUserId();
            if(userid!=vehicle.UserId)
            {
                return StatusCode(HttpStatusCode.Conflict)
                    ;
            }
            db.Entry(vehicle).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Vehicles
        [ResponseType(typeof(Vehicle))]
        public IHttpActionResult PostVehicle(Vehicle vehicle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userid = User.Identity.GetUserId();
            vehicle.UserId = userid;
            db.Vehicles.Add(vehicle);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vehicle.VehicleId }, vehicle);
        }

        // DELETE: api/Vehicles/5
        [ResponseType(typeof(Vehicle))]
        public IHttpActionResult DeleteVehicle(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
          
            if (vehicle == null)
            {
                return NotFound();
            }
            var userid = User.Identity.GetUserId();
            if (vehicle.UserId!=userid)
            {
                return StatusCode(HttpStatusCode.Conflict);
            }
              db.Vehicles.Remove(vehicle);
            db.SaveChanges();

            return Ok(vehicle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleExists(int id)
        {
            return db.Vehicles.Count(e => e.VehicleId == id) > 0;
        }
    }
}