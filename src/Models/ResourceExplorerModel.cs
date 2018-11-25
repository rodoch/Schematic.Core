using System.Collections.Generic;

namespace Schematic.Core
{
    public class ResourceExplorerModel
    {
        public int? ResourceID { get; set; }

        public string ResourceType { get; set; }

        public Dictionary<string, string> Facets { get; set; }
    }
}