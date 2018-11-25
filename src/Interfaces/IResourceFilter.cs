using System.Collections.Generic;

namespace Schematic.Core
{
    public interface IResourceFilter<T>
    {
        int ActiveResourceID { get; set; }

        string SearchQuery { get; set; }
        
        Dictionary<string, string> Facets { get; set; }
    }
}