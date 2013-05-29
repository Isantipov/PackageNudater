using System;
using System.Collections.Generic;

namespace PackageNudater.Core
{
    internal class ConfigReader
    {
        private string fileName;

        public ConfigReader(string fileName)
        {
            this.fileName = fileName;
        }

        public IEnumerable<PackageInfo> Read()
        {
            throw new NotImplementedException();
        }
    }
}