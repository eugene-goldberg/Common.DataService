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

namespace CommonDataService.UdmControllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FactController : ODataController
    {
        UDMContext db = new UDMContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<Fact> Get()
        {
            return db.Facts;
        }

        [EnableQuery]
        public SingleResult<Fact> Get([FromODataUri] int key)
        {
            IQueryable<Fact> result = db.Facts.Where(p => p.AccountKey == key);
            return SingleResult.Create(result);
        }
    }
}
