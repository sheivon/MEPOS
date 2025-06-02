using System.Web.Optimization;

namespace Marshell_Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //"~/Scripts/jquery-{version}.js", 
                        "~/Scripts/jquery-3.7.1.min.js",
                        "~/Scripts/jquery.scrollbar.min.js",
                        "~/Scripts/jquery-validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-notify.js",
                      "~/Scripts/pdfmake.min.js",  /* Include pdfMake for PDF export */
                      "~/Scripts/vfs_fonts.js",
                      "~/Scripts/filesaver.min.js",
                      "~/Scripts/jszip.min.js",  
                      "~/Scripts/webfont.min.js",
                      "~/Scripts/fontawesome/all.min.js",
                      "~/Scripts/fontawesome/fontawesome.js", 
                      "~/Scripts/sweetalert.min.js", 
                      "~/Scripts/dataTables.js", 
                      "~/Scripts/sidebar.js",
                      "~/Scripts/colornodes.js",
                      "~/Scripts/bootstrap.bundle.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/dataTables.dataTables.css", 
                      "~/Content/fontawesome.css",
                      "~/Content/all.min.css",
                      "~/Content/simplebar.css",
                      "~/Content/MyStyle.css" ));
        }
    }
}
