using System.Collections.Generic;

namespace Schematic.Core
{
    public class ResourceModel<T>
    {
        public int ResourceID { get; set; }

        public T Resource { get; set; }

        public Dictionary<string, string> Facets { get; set; }
    }
}