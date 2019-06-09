using System;

namespace PariService.Code
{
    public class PariException : Exception
    {
        public string Body { get; }

        public PariException(string message, string body = null) : base(message)
        {
            Body = body;
        }
    }
}