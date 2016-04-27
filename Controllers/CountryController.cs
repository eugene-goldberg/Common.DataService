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
    public class CountryController : ODataController
    {
        MALContext db = new MALContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<Country> Get()
        {
            return db.Countries;
        }

        [EnableQuery]
        public SingleResult<Country> Get([FromODataUri] int key)
        {
            IQueryable<Country> result = db.Countries.Where(p => p.CountryID == key);
            return SingleResult.Create(result);
        }
    }
}
