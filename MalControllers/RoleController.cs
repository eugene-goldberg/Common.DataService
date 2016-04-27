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
    public class RoleController : ODataController
    {
        MALContext db = new MALContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<Role> Get()
        {
            return db.Roles;
        }

        [EnableQuery]
        public SingleResult<Role> Get([FromODataUri] int key)
        {
            IQueryable<Role> result = db.Roles.Where(p => p.RoleID == key);
            return SingleResult.Create(result);
        }
    }
}
