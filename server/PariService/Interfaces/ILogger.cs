using System;

namespace PariService.Interfaces
{
    public interface ILogger
    {
        string LogException(Exception ex);
    }
}