using System;
using PariService.Helpers;
using PariService.Interfaces;

namespace PariService.Code
{
    public class Logger : ILogger
    {
        public string LogException(Exception ex)
        {
            var errorId = Guid.NewGuid();
            var body = ex is PariException exception ? $"Body : {exception.Body} \r\n" : string.Empty;
            var date = $"{System.DateTime.Now: yyyy MMMM dd HH:mm:ss.fff tt zz}";
            Console.WriteLine($"Message: {ex.Message} \r\n Date: {date} \r\n Error ID: {errorId} \r\n {body} StackTrace: {ex.StackTrace}");

            var message = ex is PariException ? ex.Message : Const.Messages.InternalError;
            return $"Message: {message};  Date: {date};  Error ID: {errorId}";
        }
    }
}