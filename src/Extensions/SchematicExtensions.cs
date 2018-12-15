using System;
using System.Collections.Generic;

namespace Schematic.Core
{
    public static class SchematicExtensions
    {
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

        public static bool HasValue(this string value) => !IsNullOrWhiteSpace(value);

        public static dynamic HasValueOrDBNull(this string value)
        {
            if (value.HasValue())
            {
                return value;
            }
            else
            {
                return DBNull.Value;
            }
        }

        public static dynamic HasValueOrDBNull(this int? value)
        {
            if (value != null)
            {
                return value;
            }
            else
            {
                return DBNull.Value;
            }
        }

        public static Dictionary<string, string> GetFacets(this string facets)
        {
            var result = new Dictionary<string, string>();

            if (facets.HasValue())
            {
                string[] sets = facets.Split(';');

                foreach (string set in sets)
                {
                    string[] facet = set.Split(':');
                    result.Add(facet[0], facet[1]);
                }
            }

            return result;
        }
    }
}