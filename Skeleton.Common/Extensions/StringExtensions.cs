using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Common.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Return DBNull.Value if the current string is null or empty, otherwise the original string
        /// </summary>
        /// <param name="item">extension parameter</param>
        /// <returns>DBNull or the current/original string</returns>
        public static Object GetValueOrNull(this string item)
        {
            Object result;

            // This is written out because the ?: operator requires the same type (or implicit cast) between both sides of the condition
            if (String.IsNullOrEmpty(item))
            {
                result = DBNull.Value;
            }
            else
            {
                result = item;
            }
            return result;
        }

        /// <summary>
        /// Decode a base64 encoded string
        /// </summary>
        /// <param name="encodedData">extension parameter</param>
        /// <returns>Decoded base64 string</returns>
        public static string DecodeBase64String(this string encodedData)
        {
            var decodedData = Convert.FromBase64String(encodedData);
            return Encoding.UTF8.GetString(decodedData);
        }

        /// <summary>
        /// Restrict the data to max 100 characters
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string RestrictDataTo100Characters(this string data)
        {
            if (data?.Length > 100)
            {
                return data.Substring(0, 99);
            }
            return data;
        }
    }
}
