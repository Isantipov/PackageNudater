using System;
using System.Collections.Generic;

namespace PackageNudater.Core
{
    public class VersionChecker
    {
        public IEnumerable<string> GetOutdatedPackages(string packageConfigFile)
        {
            IEnumerable<PackageInfo> installedPackages = ReadInstalledPackages(packageConfigFile);
            throw new NotImplementedException();
        }

        private IEnumerable<PackageInfo> ReadInstalledPackages(string packageConfigFile)
        {
            var configReader = new ConfigReader(packageConfigFile);

            throw new NotImplementedException();
        }
    }
}
