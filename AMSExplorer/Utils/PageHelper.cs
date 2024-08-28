using Azure;
using System.Collections.Generic;
using System.Linq;

namespace AMSExplorer.Utils
{
    public static class PageHelper
    {
        public static IAsyncEnumerable<List<T>> PaginateAsync<T>(
            this AsyncPageable<T> restApiPages,
            int targetPageSize) => PaginateAsync<T>(restApiPages.AsPages(), targetPageSize);

        public static async IAsyncEnumerable<List<T>> PaginateAsync<T>(
            this IAsyncEnumerable<Page<T>> restApiPages,
            int targetPageSize)
        {
            var buffer = new List<T>();

            await foreach (var restApiPage in restApiPages)
            {
                foreach (var item in restApiPage.Values)
                {
                    buffer.Add(item);

                    // If the buffer reaches the target page size, yield it as a page
                    if (buffer.Count == targetPageSize)
                    {
                        yield return buffer.ToList();
                        buffer.Clear();
                    }
                }
            }

            // Yield any remaining items in the buffer as the last page
            if (buffer.Count > 0)
            {
                yield return buffer.ToList();
            }
        }
    }

}
