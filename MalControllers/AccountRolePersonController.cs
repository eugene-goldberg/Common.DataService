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
    public class AccountRolePersonController : ODataController
    {
        MALContext db = new MALContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<AccountRolePerson> Get()
        {
            return db.AccountRolePersons;
        }

        [EnableQuery]
        public SingleResult<AccountRolePerson> Get([FromODataUri] string key)
        {
            IQueryable<AccountRolePerson> result = db.AccountRolePersons.Where(p => p.AccountID == key);
            return SingleResult.Create(result);
        }
    }
}
