
namespace System.Web.Hosting
{
    public partial class HostingEnvironment
    {
        public static string ApplicationPath => null;
        public static string ApplicationVirtualPath => null;
        public static bool IsHosted => false;
        public static string SiteName => null;

        public static string MapPath(string virtualPath) => null;
    }
}