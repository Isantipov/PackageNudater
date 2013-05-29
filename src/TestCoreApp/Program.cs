using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageNudater.Core;

namespace TestCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var checker = new VersionChecker();
            var packages =
                checker.GetOutdatedPackages(
                    @"d:\_work\investigation\HotScrollGit\HotScroll\src\HotScroll.Server\HotScroll.Server\packages.config");

            foreach (var package in packages)
            {
                Console.WriteLine(package);
            }
        }
    }
}
