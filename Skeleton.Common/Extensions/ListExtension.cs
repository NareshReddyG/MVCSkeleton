using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Common.Extensions
{
    public static class ListExtension
    {
        public static bool HasSingleItem<T>(this List<T> item)
        {
            return item != null && item.Count() == 1;
        }
    }
}
