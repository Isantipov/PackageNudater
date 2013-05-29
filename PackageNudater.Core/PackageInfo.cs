namespace PackageNudater.Core
{
    public class PackageInfo
    {
        public string Id { get; set; }

        public string Version { get; set; }

        public string LatestVersion { get; set; }

        public bool IsOutdated { get; set; }
    }
}