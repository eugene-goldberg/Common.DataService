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
    public class IndustryController : ODataController
    {
        MALContext db = new MALContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<Industry> Get()
        {
            return db.Industries;
        }

        [EnableQuery]
        public SingleResult<Industry> Get([FromODataUri] int key)
        {
            IQueryable<Industry> result = db.Industries.Where(p => p.IndustryID == key);
            return SingleResult.Create(result);
        }
    }
}
