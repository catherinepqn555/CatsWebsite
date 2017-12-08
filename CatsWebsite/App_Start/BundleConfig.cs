using System.Web;
using System.Web.Optimization;

namespace CatsWebsite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/CSS/bootstrap.css",
                "~/Content/CSS/site.css"));
        }
    }
}
