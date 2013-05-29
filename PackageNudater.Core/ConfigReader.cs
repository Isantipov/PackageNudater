using System;
using System.Collections.Generic;
using System.Xml;

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
            var xmlDocumnet = new XmlDocument();
            xmlDocumnet.Load(fileName);

            var packages = new List<PackageInfo>();
            var packageNodes = xmlDocumnet.DocumentElement.ChildNodes;
            foreach (XmlNode packageNode in packageNodes)
            {
                packages.Add(ReadPackageNode(packageNode));
            }

            return packages;
        }

        private PackageInfo ReadPackageNode(XmlNode packageNode)
        {
            var packageInfo = new PackageInfo
                {
                    Id = packageNode.Attributes["id"].Value,
                    Version = packageNode.Attributes["version"].Value,
                };
            

            return packageInfo;
        }
    }
}