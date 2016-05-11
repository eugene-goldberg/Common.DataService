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
    public class IncidentController : ODataController
    {
        MALContext db = new MALContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<Incident> Get()
        {
            return db.Incidents;
        }

        [EnableQuery]
        public SingleResult<Incident> Get([FromODataUri] string key)
        {
            IQueryable<Incident> result = db.Incidents.Where(p => p.INCIDENTNUMBER == key);
            return SingleResult.Create(result);
        }
    }
}
