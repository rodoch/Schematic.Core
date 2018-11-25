using System.Collections.Generic;

namespace Schematic.Core
{
    public class ResourceListModel<T>
    {
        public int ActiveResourceID { get; set; }
        public List<T> List { get; set; }
    }
}