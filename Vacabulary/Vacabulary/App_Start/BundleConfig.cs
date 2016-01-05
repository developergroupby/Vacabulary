using System.Web;
using System.Web.Optimization;

namespace Vacabulary
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/libs/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/libs/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/libs/bootstrap.js",
                      "~/Scripts/libs/respond.js",
                      "~/Scripts/libs/fileinput/fileinput.js",
                      "~/Scripts/libs/bootstrap-filestyle.js",
                      "~/Scripts/libs/angular.js",
                      "~/Scripts/libs/angular-ui-router.js"));

            bundles.Add(new StyleBundle("~/Content/styles").Include(
                      "~/Content/css/site.css",
                      "~/Content/css/libs/bootstrap.css",
                      "~/Content/css/libs/fileinput.css"
                      ));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
