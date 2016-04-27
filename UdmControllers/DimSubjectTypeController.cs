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
    public class DimSubjectTypeController : ODataController
    {
        UDMContext db = new UDMContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<DimSubjectType> Get()
        {
            return db.DimSubjectTypes;
        }

        [EnableQuery]
        public SingleResult<DimSubjectType> Get([FromODataUri] int key)
        {
            IQueryable<DimSubjectType> result = db.DimSubjectTypes.Where(p => p.SubjectTypeKey == key);
            return SingleResult.Create(result);
        }
    }
}
