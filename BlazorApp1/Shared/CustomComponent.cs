using Microsoft.AspNetCore.Components;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public abstract class CustomComponent : ComponentBase, IDisposable
    {
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        protected override Task OnInitializedAsync()
        {
            return Task.WhenAll(base.OnInitializedAsync(), LoadAsync(_cts.Token));
        }

        protected virtual Task LoadAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _cts.Cancel();
        }
    }
}
