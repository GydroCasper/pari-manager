using System;
using PariService.Helpers;
using PariService.Interfaces;

namespace PariService.Code
{
    public class Logger : ILogger
    {
        public string LogException(Exception ex, string requestId)
        {
            var body = ex is PariException exception ? $"Body : {exception.Body} \r\n" : string.Empty;
            var date = $"{DateTime.Now: yyyy MMMM dd HH:mm:ss.fff tt zz}";

            var summaryExceptionMessage = ex.Message;
            var innerException = ex.InnerException;
            while (innerException != null)
            {
                summaryExceptionMessage += $"\r\n{innerException.Message}";
                innerException = innerException.InnerException;
            }

            Console.WriteLine($"Message: {summaryExceptionMessage} \r\n Date: {date} \r\n Request ID: {requestId} \r\n {body} StackTrace: {ex.StackTrace}");

            var message = ex is PariException ? ex.Message : Const.Messages.InternalError;
            return $"Message: {message};  Date: {date};  Request ID: {requestId}";
        }
    }
}