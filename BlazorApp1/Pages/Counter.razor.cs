using BlazorApp1.Services;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Components;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public partial class CounterComponent : CustomComponent
    {

        [Inject]
        private DataService _dataService { get; set; }

        public int CurrentCount = 0;

        public void IncrementCount()
        {
            CurrentCount++;
        }

        protected override async Task LoadAsync(CancellationToken cancellationToken)
        {
            await _dataService.DoWorkAsync(cancellationToken);
            await base.LoadAsync(cancellationToken);
            CurrentCount = 10000;
        }
    }
}
