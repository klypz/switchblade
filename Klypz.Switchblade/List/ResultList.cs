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

        public ResultList(int pageSize, int currentPage, int count)
        {
            PageSize = pageSize;
            CurrentPage = currentPage;
            Count = count;
        }

        public int PageSize { get; private set; }
        public int CurrentPage { get; private set; }
        public int Pages { get { return Math.Abs(Count / PageSize) + (Math.Abs(Count / PageSize) < Count * 1.0 / PageSize * 1.0 ? 1 : 0); } }
        public int Count { get; private set; }

        public List<T> Result { get; set; }

        public void SetQuery(IQueryable<T> query)
        {
            int total = query.Count();
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
            Count = total;
        }
    }
}
