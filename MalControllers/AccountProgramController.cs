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
    public class AccountProgramController : ODataController
    {
        MALContext db = new MALContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<AccountProgram> Get()
        {
            return db.AccountPrograms;
        }

        [EnableQuery]
        public SingleResult<AccountProgram> Get([FromODataUri] string key)
        {
            IQueryable<AccountProgram> result = db.AccountPrograms.Where(p => p.AccountID == key);
            return SingleResult.Create(result);
        }
    }
}
