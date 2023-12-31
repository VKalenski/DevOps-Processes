using System.Reflection;

namespace BlazorApp
{
    public static class GetSiteVersionExtension
    {
        public static Version GetSiteVersion()
        {
            Version version = Assembly.GetExecutingAssembly()?.GetName().Version ?? new Version(1, 0, 0, 0);
            return version;
        }
    }
}