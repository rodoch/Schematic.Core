using System;
using System.Collections.Generic;

namespace Schematic.Core
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty(this string s) => string.IsNullOrEmpty(s);

        public static bool HasValue(this string s) => !IsNullOrEmpty(s);

        public static dynamic HasValueOrDBNull(this string s)
        {
            if (s.HasValue())
            {
                return s;
            }
            else
            {
                return DBNull.Value;
            }
        }

        public static dynamic HasValueOrDBNull(this int? i)
        {
            if (i != null)
            {
                return i;
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