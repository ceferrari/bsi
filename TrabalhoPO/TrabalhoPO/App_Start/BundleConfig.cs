using System.Web.Optimization;

public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        /* Scripts */
        bundles.Add(new ScriptBundle("~/Scripts/jquery")
                    .Include("~/Scripts/jquery-{version}.js"));

        //bundles.Add(new ScriptBundle("~/bundles/jqueryval") { Orderer = new AsIsBundleOrderer() }
        //            .Include("~/Scripts/jquery.validate.js",
        //                     "~/Scripts/jquery.validtae.unobtrusive.js",
        //                     "~/Scripts/globalize.js",
        //                     "~/Scripts/jquery.validate.globalize.js"));

        bundles.Add(new ScriptBundle("~/Scripts/bootstrap")
                    .Include("~/Scripts/bootstrap.js"));

        bundles.Add(new ScriptBundle("~/Scripts/main")
                    .Include("~/Scripts/App/main.js"));

        bundles.Add(new ScriptBundle("~/Scripts/produto")
                    .Include("~/Scripts/App/produto.js"));

        /* Styles */
        bundles.Add(new StyleBundle("~/Content/bootstrap")
                    .Include("~/Content/bootstrap.css"));

        bundles.Add(new StyleBundle("~/Content/font-awesome")
                    .Include("~/Content/font-awesome.css"));

        bundles.Add(new StyleBundle("~/Content/App/main")
                    .Include("~/Content/App/main.css"));

        /* Configs */
        #if DEBUG
            BundleTable.EnableOptimizations = false;
        #else
            BundleTable.EnableOptimizations = true;
        #endif
    }
}