using System.Web;
using System.Web.Optimization;

namespace Monash.Cad
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));


            bundles.Add(new ScriptBundle(virtualPath: "~/bundles/js").Include(
                "~/Scripts/jquery-3.1.1.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/bootstrap-progressbar.min.js",
                "~/Scripts/kendo/kendo.all.min.js",
                "~/Scripts/kendo/kendo.aspnetmvc.min.js",
                "~/Scripts/jquery.nicescroll.min.js")
                );

            bundles.Add(new StyleBundle(virtualPath: "~/Content/kendo/2017.3.1026/css").Include(
               "~/Content/kendo/kendo.common.min.css",
               "~/Content/kendo/kendo.default.min.css",
               "~/Content/kendo/kendo.material.min.css",
               "~/Content/kendo.custom.css",
               "~/Content/kendo/kendo.dataviz.min.css",
               "~/Content/kendo/kendo.dataviz.default.min.css"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
