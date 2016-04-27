using CommonDataService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.OData;

namespace CommonDataService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ChangeMeasureController : ODataController
    {
        MALContext db = new MALContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<ChangeMeasure> Get()
        {
            return db.ChangeMeasures;
        }

        [EnableQuery]
        public SingleResult<ChangeMeasure> Get([FromODataUri] int key)
        {
            IQueryable<ChangeMeasure> result = db.ChangeMeasures.Where(p => p.ID == key);
            return SingleResult.Create(result);
        }

        public async Task<IHttpActionResult> Post(ChangeMeasure record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.ChangeMeasures.Add(record);
            db.SaveChanges();
            return Created(record);
        }

        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<ChangeMeasure> product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity =  db.ChangeMeasures.Find(key);
            if (entity == null)
            {
                return NotFound();
            }
            product.Patch(entity);
        
                db.SaveChanges();
                     
            return Updated(entity);
        }

        public async Task<IHttpActionResult> Put([FromODataUri] int key, ChangeMeasure update)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (key != update.ID)
            {
                return BadRequest();
            }
            db.Entry(update).State = EntityState.Modified;
                
            db.SaveChanges();
           
            return Updated(update);
        }
    }
}
