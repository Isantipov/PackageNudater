using System;
using System.Collections.Generic;
using System.Linq;
using NuGet;

namespace PackageNudater.Core
{
    public class VersionChecker
    {
        IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");

        public IEnumerable<string> GetOutdatedPackages(string packageConfigFile)
        {
            IEnumerable<PackageInfo> installedPackages = ReadInstalledPackages(packageConfigFile);

            var outdated = new List<string>();

            foreach (var packageInfo in installedPackages)
            {
                SetLatestVersio(packageInfo);
                if (packageInfo.IsOutdated)
                {
                    outdated.Add(packageInfo.Id);
                }
            }


            return outdated;
        }

        private void SetLatestVersio(PackageInfo packageInfo)
        {
            var packageFromRepo = repo.FindPackage(packageInfo.Id);

            packageInfo.LatestVersion = packageFromRepo.Version.ToString();
            var oldVersion = SemanticVersion.Parse(packageInfo.Version);
            packageInfo.IsOutdated = packageFromRepo.Version.CompareTo(oldVersion) > 0;

        }

        private IEnumerable<PackageInfo> ReadInstalledPackages(string packageConfigFile)
        {
            var configReader = new ConfigReader(packageConfigFile);

            return configReader.Read();
        }
    }
}
