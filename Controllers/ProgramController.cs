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
    public class ProgramController : ODataController
    {
        MALContext db = new MALContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<CommonDataService.Models.Program> Get()
        {
            return db.Programs;
        }

        [EnableQuery]
        public SingleResult<CommonDataService.Models.Program> Get([FromODataUri] int key)
        {
            IQueryable<CommonDataService.Models.Program> result = db.Programs.Where(p => p.ProgramID == key);
            return SingleResult.Create(result);
        }
    }
}
