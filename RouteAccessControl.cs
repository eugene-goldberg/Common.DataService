using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;
using Nancy;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using System.Web.Http.Cors;
using CommonDataService.Models;
using System.Web.OData;
using System.Net.Http;
using System.Web.OData.Query;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using System.Security.Principal;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace CommonDataService
{
    //public class SecureAccessAttribute : EnableQueryAttribute
    //{
    //    public override void ValidateQuery(HttpRequestMessage request, ODataQueryOptions queryOptions)
    //    {
    //        if (queryOptions.SelectExpand != null
    //            && queryOptions.SelectExpand.RawExpand != null
    //            && queryOptions.SelectExpand.RawExpand.Contains("Incident"))
    //        {
    //            //Check here if user is allowed to view orders.
    //            throw new InvalidOperationException();
    //        }

    //        base.ValidateQuery(request, queryOptions);
    //    }
    //}
 
public class RouteAccessControl : AuthorizeAttribute
{
    protected override bool IsAuthorized(HttpActionContext actionContext)
    {

        IEnumerable<string> headerValues = actionContext.Request.Headers.GetValues("sender");
        var id = headerValues.FirstOrDefault();
        //IPrincipal incomingPrincipal = actionContext.RequestContext.Principal;
        //Debug.WriteLine(string.Format("Principal is authenticated at the start of IsAuthorized in CustomAuthorizationFilterAttribute: {0}", incomingPrincipal.Identity.IsAuthenticated));
        if (id == "eugene")
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
 
    protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
    {
        Debug.WriteLine("Running HandleUnauthorizedRequest in CustomAuthorizationFilterAttribute as principal is not authorized.");
                base.HandleUnauthorizedRequest(actionContext);
    }
}
 
}
