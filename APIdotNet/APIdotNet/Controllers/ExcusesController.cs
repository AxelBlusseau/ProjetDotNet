using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using APIdotNet.Models;

namespace APIdotNet.Controllers
{
    public class ExcusesController : ApiController
    {
        private APIdotNetContext db = new APIdotNetContext();

        [HttpGet]
        [Route("GetTen")]
        public IQueryable<Excuse> GetTen()
        {
            IQueryable<Excuse> excuses = db.Excuses.Include("User");
            var items = excuses.OrderByDescending(e => e.NbVote).Take(10);
            return items;
        }
        [HttpGet]
        [Route("TopItByMonth")]
        public IQueryable<Excuse> GetTopExcuseByMonth()
        {
            IQueryable<Excuse> excuses = db.Excuses.Include("User");
            var items = excuses.Where(e => e.Date.Month == DateTime.Now.Month).OrderByDescending(v => v.NbVote).Take(2);
            return items;
        }

        [HttpGet]
        [Route("TopItByYear")]
        public IQueryable<Excuse> GetTopExcuseByYear()
        {
            IQueryable<Excuse> excuses = db.Excuses.Include("User");
            var items = excuses.Where(e => e.Date.Year == DateTime.Now.Year).OrderByDescending(v => v.NbVote).Take(2);
            return items;
        }

        // GET: api/Excuses
        public IQueryable<Excuse> GetExcuses()
        {
            return db.Excuses.Include("User");
        }

        // GET: api/Excuses/5
        [ResponseType(typeof(Excuse))]
        public async Task<IHttpActionResult> GetExcuse(int id)
        {
            Excuse excuse = await db.Excuses.FindAsync(id);
            if (excuse == null)
            {
                return NotFound();
            }

            return Ok(excuse);
        }

        // PUT: api/Excuses/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutExcuse(int id, Excuse excuse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != excuse.Id)
            {
                return BadRequest();
            }

            db.Entry(excuse).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExcuseExists(id))
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

        // POST: api/Excuses
        [ResponseType(typeof(Excuse))]
        public async Task<IHttpActionResult> PostExcuse(Excuse excuse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Excuses.Add(excuse);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = excuse.Id }, excuse);
        }

        // DELETE: api/Excuses/5
        [ResponseType(typeof(Excuse))]
        public async Task<IHttpActionResult> DeleteExcuse(int id)
        {
            Excuse excuse = await db.Excuses.FindAsync(id);
            if (excuse == null)
            {
                return NotFound();
            }

            db.Excuses.Remove(excuse);
            await db.SaveChangesAsync();

            return Ok(excuse);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExcuseExists(int id)
        {
            return db.Excuses.Count(e => e.Id == id) > 0;
        }
    }
}