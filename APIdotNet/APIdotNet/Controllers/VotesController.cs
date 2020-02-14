﻿using System;
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
    public class VotesController : ApiController
    {
        private APIdotNetContext db = new APIdotNetContext();

        // GET: api/Votes
        public IQueryable<Vote> GetVotes()
        {
            return db.Votes;
        }

        // GET: api/Votes/5
        [ResponseType(typeof(Vote))]
        public async Task<IHttpActionResult> GetVote(int id)
        {
            Vote vote = await db.Votes.FindAsync(id);
            if (vote == null)
            {
                return NotFound();
            }

            return Ok(vote);
        }

        // PUT: api/Votes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVote(int id, Vote vote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vote.idExcuse)
            {
                return BadRequest();
            }

            db.Entry(vote).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoteExists(id))
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

        // POST: api/Votes
        [ResponseType(typeof(Vote))]
        public async Task<IHttpActionResult> PostVote(Vote vote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Votes.Add(vote);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VoteExists(vote.idExcuse))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = vote.idExcuse }, vote);
        }

        // DELETE: api/Votes/5
        [ResponseType(typeof(Vote))]
        public async Task<IHttpActionResult> DeleteVote(int id)
        {
            Vote vote = await db.Votes.FindAsync(id);
            if (vote == null)
            {
                return NotFound();
            }

            db.Votes.Remove(vote);
            await db.SaveChangesAsync();

            return Ok(vote);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VoteExists(int id)
        {
            return db.Votes.Count(e => e.idExcuse == id) > 0;
        }
    }
}