using System.Web;
using System.Web.Optimization;

namespace CatsWebsite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Content/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/Scripts/bootstrap.js",
                      "~/Content/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
                "~/Content/css/bootstrap.css",
                "~/Content/css/site.css"));
        }
    }
}
