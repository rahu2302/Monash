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
using Monash.Cad.Api.Entity;

namespace Monash.Cad.Api.Controllers
{
    public class DelegationApiController : ApiController
    {
        private DelegationEntity db = new DelegationEntity();

        // GET: api/DelegationApi
        public IQueryable<ApprovalDelegationHeader> GetApprovalDelegationHeaders()
        {
            return db.ApprovalDelegationHeaders;
        }

        // GET: api/DelegationApi/5
        [ResponseType(typeof(ApprovalDelegationHeader))]
        public IHttpActionResult GetApprovalDelegationHeader(int id)
        {
            ApprovalDelegationHeader approvalDelegationHeader = db.ApprovalDelegationHeaders.Find(id);
            if (approvalDelegationHeader == null)
            {
                return NotFound();
            }

            return Ok(approvalDelegationHeader);
        }

        // PUT: api/DelegationApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutApprovalDelegationHeader(int id, ApprovalDelegationHeader approvalDelegationHeader)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != approvalDelegationHeader.Id)
            {
                return BadRequest();
            }

            db.Entry(approvalDelegationHeader).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApprovalDelegationHeaderExists(id))
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

        // POST: api/DelegationApi
        [ResponseType(typeof(ApprovalDelegationHeader))]
        public IHttpActionResult PostApprovalDelegationHeader(ApprovalDelegationHeader approvalDelegationHeader)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.ApprovalDelegationHeaders.Add(approvalDelegationHeader);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = approvalDelegationHeader.Id }, approvalDelegationHeader);
        }

        // DELETE: api/DelegationApi/5
        [ResponseType(typeof(ApprovalDelegationHeader))]
        public IHttpActionResult DeleteApprovalDelegationHeader(int id)
        {
            ApprovalDelegationHeader approvalDelegationHeader = db.ApprovalDelegationHeaders.Find(id);
            if (approvalDelegationHeader == null)
            {
                return NotFound();
            }

            db.ApprovalDelegationHeaders.Remove(approvalDelegationHeader);
            db.SaveChanges();

            return Ok(approvalDelegationHeader);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ApprovalDelegationHeaderExists(int id)
        {
            return db.ApprovalDelegationHeaders.Count(e => e.Id == id) > 0;
        }
    }
}