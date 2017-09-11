//
//  BundleConfig.cs
//
//  Wiregrass Code Technology 2017
//
using System.Web.Optimization;

namespace PortalGateway
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            if (bundles != null)
            {
                bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"));
                bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
                bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include("~/Scripts/jquery-ui-{version}.js", "~/Scripts/jquery-ui.unobtrusive-{version}.js"));
                bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));
                bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

                bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/site.css"));
                bundles.Add(new StyleBundle("~/Content/themes/base/css").Include("~/Content/themes/base/jquery.ui.core.css", "~/Content/themes/base/jquery.ui.theme.css"));
            }
        }
    }
}