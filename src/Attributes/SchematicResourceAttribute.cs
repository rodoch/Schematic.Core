using System;

namespace Schematic.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SchematicResourceAttribute : Attribute
    {
        public SchematicResourceAttribute(string route = "")
        {
            Route = route;
        }
            
        public string Route { get; set; }
    }
}