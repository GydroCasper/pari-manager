using System;
using System.Threading.Tasks;
using PariService.Helpers;

namespace PariService.Interfaces
{
    public interface IRun
    {
        Task<PariResponse<TResult>> Run<TArg, TResult>(Func<TArg, Task<TResult>> func, TArg arg);

        Task<PariResponse<TResult>> Run<TResult>(Func<Task<TResult>> func);
    }
}