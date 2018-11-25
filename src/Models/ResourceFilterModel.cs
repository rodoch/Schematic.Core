using System.Collections.Generic;

namespace Schematic.Core
{
    public class ResourceFilterModel<T> : IResourceFilter<T>
    {
        public int ActiveResourceID { get; set; }
        public string SearchQuery { get; set; }
        public Dictionary<string, string> Facets { get; set; }
    }
}