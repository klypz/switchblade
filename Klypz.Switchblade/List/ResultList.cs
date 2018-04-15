using System;
using System.Collections.Generic;
using System.Linq;

namespace Klypz.Switchblade.List
{
    public class ResultList<T>
    {
        public ResultList(int pageSize, int currentPage)
        {
            PageSize = pageSize;
            CurrentPage = currentPage;
        }

        public int PageSize { get; private set; }
        public int CurrentPage { get; private set; }
        public int Pages { get; private set; }
        public int Count { get; private set; }

        public List<T> Result { get; private set; }

        public void SetQuery(IQueryable<T> query)
        {
            int total = query.Count();
            Pages = Math.Abs(total / PageSize) + (Math.Abs(total / PageSize) < total * 1.0 / PageSize * 1.0 ? 1 : 0);
            Count = total;

            Result = query.Pagination(PageSize, CurrentPage).ToList();
        }

        public void SetQuery(IEnumerable<T> query)
        {
            ProcesseInfoQuery(query.Count());
            Result = query.Pagination(PageSize, CurrentPage).ToList();
        }

        private void ProcesseInfoQuery(int count)
        {
            int total = count;
            Pages = Math.Abs(total / PageSize) + (Math.Abs(total / PageSize) < total * 1.0 / PageSize * 1.0 ? 1 : 0);
            Count = total;
        }
    }
}
