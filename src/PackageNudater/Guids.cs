// Guids.cs
// MUST match guids.h
using System;

namespace Isantipov.PackageNudater
{
    static class GuidList
    {
        public const string guidPackageNudaterPkgString = "df7211e7-f8c1-4954-8d56-a7c5c3aefcb8";
        public const string guidPackageNudaterCmdSetString = "b5091c76-881f-437c-8a55-d73c403fc129";

        public static readonly Guid guidPackageNudaterCmdSet = new Guid(guidPackageNudaterCmdSetString);
    };
}