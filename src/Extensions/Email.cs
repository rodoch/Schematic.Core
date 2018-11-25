using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Schematic.Core
{
    public static class Email
    {
        private static readonly Regex _sanitizeUrl = new Regex(@"[^-a-z0-9+&@#/%?=~_|!:,.;\*\(\)\{\}]", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <summary>
        /// Encodes the string as HTML.
        /// </summary>
        /// <param name="s">The dangerous string to encode.</param>
        /// <returns>The safely encoded HTML string.</returns>
        public static string HtmlEncode(this string s) => s.HasValue() ? WebUtility.HtmlEncode(s) : s;

        /// <summary>
        /// Decodes an HTML string.
        /// </summary>
        /// <param name="s">The HTML-encoded string to decode.</param>
        /// <returns>The decoded HTML string.</returns>
        public static string HtmlDecode(this string s) => s.HasValue() ? WebUtility.HtmlDecode(s) : s;

        /// <summary>
        /// Encodes the string for URLs.
        /// </summary>
        /// <param name="s">The dangerous string to URL encode.</param>
        /// <returns>The safely encoded URL string.</returns>
        public static string UrlEncode(this string s) => s.HasValue() ? WebUtility.UrlEncode(s) : s;

        /// <summary>
        /// Decodes a URL-encoded string.
        /// </summary>
        /// <param name="s">The URL-encoded string to decode.</param>
        /// <returns>The decoded string.</returns>
        public static string UrlDecode(this string s) => s.HasValue() ? WebUtility.UrlDecode(s) : s;
        
        /// <summary>
        /// Sanitizes a URL for safety.
        /// </summary>
        /// <param name="url">The URL string to sanitize.</param>
        /// <returns>The sanitized URL.</returns>
        public static string SanitizeUrl(string url) => url.IsNullOrEmpty() ? url : _sanitizeUrl.Replace(url, "");
        
        /// <summary>
        /// Linkifies a URL, returning an anchor-wrapped version if sane.
        /// </summary>
        /// <param name="s">The URL string to attempt to linkify.</param>
        /// <param name="color">The HTML color to use (hex code or name).</param>
        /// <returns>The linified string, or the encoded string if not a safe URL.</returns>
        public static string Linkify(string s, string color = "#3D85B0")
        {
            if (s.IsNullOrEmpty())
            {
                return string.Empty;
            }

            if (Regex.IsMatch(s, "%[A-Z0-9][A-Z0-9]"))
            {
                s = s.UrlDecode();
            }

            if (Regex.IsMatch(s, "^(https?|ftp|file)://"))
            {
                //@* || (Regex.IsMatch(s, "/[^ /,]+/") && !s.Contains("/LM"))*@ // block special case of "/LM/W3SVC/1"
                var sane = SanitizeUrl(s);
                if (sane == s) // only link if it's not suspicious
                    return $@"<a style=""color: {color};"" href=""{sane}"">{s.HtmlEncode()}</a>";
            }

            return s.HtmlEncode();
        }

        public static StringBuilder AppendParagraph(this StringBuilder sb, string content)
        {
            var paragraph = "<p>" + content + "</p>";
            return sb.AppendLine(paragraph);
        }

        public static StringBuilder AppendLineBreak(this StringBuilder sb)
        {
            return sb.AppendLine("<br/>");
        }
    }
}