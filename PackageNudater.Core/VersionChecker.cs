using System;
using System.Collections.Generic;
using System.Linq;

namespace PackageNudater.Core
{
    public class VersionChecker
    {
        public IEnumerable<string> GetOutdatedPackages(string packageConfigFile)
        {
            IEnumerable<PackageInfo> installedPackages = ReadInstalledPackages(packageConfigFile);
            return installedPackages.Select(i => i.Id + "   " + i.Version);
        }

        private IEnumerable<PackageInfo> ReadInstalledPackages(string packageConfigFile)
        {
            var configReader = new ConfigReader(packageConfigFile);

            return configReader.Read();
        }
    }
}
