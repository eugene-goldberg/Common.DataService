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
    public class DimStatusController : ODataController
    {
        UDMContext db = new UDMContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<DimStatu> Get()
        {
            return db.DimStatus;
        }

        [EnableQuery]
        public SingleResult<DimStatu> Get([FromODataUri] int key)
        {
            IQueryable<DimStatu> result = db.DimStatus.Where(p => p.StatusKey == key);
            return SingleResult.Create(result);
        }
    }
}
