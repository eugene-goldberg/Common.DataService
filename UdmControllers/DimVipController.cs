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
    public class DimVipController : ODataController
    {
        UDMContext db = new UDMContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<DimVip> Get()
        {
            return db.DimVips;
        }

        [EnableQuery]
        public SingleResult<DimVip> Get([FromODataUri] int key)
        {
            IQueryable<DimVip> result = db.DimVips.Where(p => p.VipKey == key);
            return SingleResult.Create(result);
        }
    }
}
