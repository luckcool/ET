using System.Collections.Generic;

namespace FUIEditor
{
    public class PackageComponentInfo
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public bool Exported { get; set; }
        
        
        public List<string> UsedPackages { get; } = new();
    }
}