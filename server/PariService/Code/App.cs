using System;
using System.Net;
using System.Threading.Tasks;
using PariService.Helpers;
using PariService.Interfaces;

namespace PariService.Code
{
    public class App: IRun
    {
        private readonly ILogger _logger;

        public App(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<PariResponse<TResult>> Run<TArg, TResult>(Func<TArg, Task<TResult>> func, TArg arg)
        {
            try
            {
                var body = await func(arg);
                return CreateSuccessResponse(body);
            }
            catch (Exception ex)
            {
                return LogException<TResult>(ex);
            }
        }

        public async Task<PariResponse<TResult>> Run<TResult>(Func<Task<TResult>> func)
        {
            try
            {
                var body = await func();
                return CreateSuccessResponse(body);
            }
            catch (Exception ex)
            {
                return LogException<TResult>(ex);
            }
        }

        private PariResponse<TResult> LogException<TResult>(Exception ex)
        {
            _logger.LogException(ex);

            return new PariResponse<TResult>
            {
                Status = HttpStatusCode.InternalServerError,
                Body = default,
                ErrorMessage = ex.Message
            };
        }

        private PariResponse<TResult> CreateSuccessResponse<TResult>(TResult body)
        {
            return new PariResponse<TResult>
            {
                Status = HttpStatusCode.OK,
                Body = body
            };
        }
    }
}