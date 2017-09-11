//
//  FilterConfig.cs
//
//  Wiregrass Code Technology 2017
//
using System.Web.Mvc;

namespace PortalGateway
{
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters?.Add(new HandleErrorAttribute());
        }
    }
}        