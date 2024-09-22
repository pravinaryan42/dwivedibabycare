using System.Web;
using System.Web.Optimization;

namespace RKD.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region [Master css]

            bundles.Add(new StyleBundle("~/bundles/MasterLayoutCss").Include(
      "~/Content/InnerCss/all.min.css", "~/Content/InnerCss/OverlayScrollbars.min.css", "~/Content/InnerCss/adminlte.css"
            ));

            #endregion

            #region [js Bundles]

            //Main Layout
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                  "~/js/InnerJs/bootstrap.min.js","~/js/InnerJs/bootstrap.bundle.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/js/InnerJs/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/globalJs").Include("~/js/alertify/alertify.min.js", "~/Scripts/global.js"));
            bundles.Add(new ScriptBundle("~/bundles/validateJs").Include(
          "~/js/InnerJs/jquery.validate.min.js",
          "~/js/InnerJs/jquery.validate.unobtrusive.min.js"));  

            bundles.Add(new ScriptBundle("~/bundles/DataTables").Include(
        "~/js/InnerJs/jquery.dataTables.js",
        "~/js/InnerJs/dataTables.bootstrap4.js", "~/js/InnerJs/jquery.fnSetFilteringEnterPress.js"
        ));
            #endregion
            #region [Login Layout]

            bundles.Add(new StyleBundle("~/bundles/LoginLayoutCss").Include(
               "~/MainPage/fonts/font-awesome.css",
               "~/MainPage/perfect-scrollbar.css",
               "~/MainPage/loginstyle.css", "~/Content/alertify/alertify.min.css"
              ));
            bundles.Add(new ScriptBundle("~/bundles/Layoutjs").Include(
          "~/js/InnerJs/jquery.overlayScrollbars.min.js", "~/js/InnerJs/adminlte.js", "~/js/InnerJs/demo.js",
"~/js/InnerJs/jquery.mousewheel.js", "~/js/InnerJs/raphael.min.js", "~/js/InnerJs/jquery.mapael.min.js",
    "~/js/InnerJs/usa_states.min.js", "~/js/InnerJs/Chart.min.js", "~/js/InnerJs/dashboard2.js"
        ));
        

            BundleTable.EnableOptimizations = true;

            #endregion
        }
    }
}
