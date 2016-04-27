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
    public class AccountController : ODataController
    {
        MALContext db = new MALContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<Account> Get()
        {
            return db.Accounts;
        }

        [EnableQuery]
        public SingleResult<Account> Get([FromODataUri] string key)
        {
            IQueryable<Account> result = db.Accounts.Where(p => p.AccountID == key);
            return SingleResult.Create(result);
        }
    }
}
