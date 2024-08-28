using Azure;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMSExplorer.Utils
{
    internal class PageIterator<T>
    {
        private readonly int _pageSize;

        private AsyncPageable<T> _query;
        private IAsyncEnumerator<List<T>> _pagesIterator;

        public PageIterator(int pageSize)
        {
            _pageSize = pageSize;

            CurrentPageNumber = 0;
            CurrentPage = new List<T>();
        }

        public int CurrentPageNumber { get; private set; }

        public IReadOnlyCollection<T> CurrentPage { get; private set; }

        public Task ResetAsync(AsyncPageable<T> query, int targetPage)
        {
            _query = query;

            return ResetInternalAsync(targetPage);
        }

        public async Task MoveNextAsync()
        {
            if (!await _pagesIterator.MoveNextAsync()
                || _pagesIterator.Current == null
                || _pagesIterator.Current.Count == 0)
            {
                return;
            }

            CurrentPage = _pagesIterator.Current;
            CurrentPageNumber++;
        }

        public Task GoToPreviousPageAsync()
        {
            if (CurrentPageNumber < 2)
            {
                return Task.CompletedTask;
            }

            return ResetInternalAsync(CurrentPageNumber - 1);
        }

        private async Task ResetInternalAsync(int targetPage)
        {
            var pages = _query.AsPages().PaginateAsync(_pageSize);

            if (_pagesIterator != null)
            {
                await _pagesIterator.DisposeAsync();
            }

            _pagesIterator = pages.Skip(targetPage - 1).GetAsyncEnumerator();
            await _pagesIterator.MoveNextAsync();

            CurrentPage = _pagesIterator.Current;
            CurrentPageNumber = targetPage;
        }
    }
}
