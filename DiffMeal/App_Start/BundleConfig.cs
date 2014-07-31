using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace DiffMeal.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Css").Include(
                "~/Content/Css/base.css"));
            bundles.Add(new ScriptBundle("~/Js").Include(
                "~/Content/Js/base.js"));
        }
    }
}