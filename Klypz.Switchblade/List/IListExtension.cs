using System.Collections.Generic;
using System.Linq;

namespace Klypz.Switchblade.List
{
    public static class IListExtension
    {
        public static IQueryable<TSource> Pagination<TSource>(this IQueryable<TSource> self, int pageSize, int page)
        {
            int initial = page * pageSize;
            int final = initial + pageSize;

            if (final > self.Count())
            {
                final = self.Count();
            }

            return self.Skip(initial).Take(final);
        }

        public static IEnumerable<TSource> Pagination<TSource>(this IEnumerable<TSource> self, int pageSize, int page)
        {
            int initial = page * pageSize;
            int final = initial + pageSize;

            if (final > self.Count())
            {
                final = self.Count();
            }

            return self.Skip(initial).Take(final);
        }
    }
}
