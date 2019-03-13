using System;
using System.Collections.Generic;
using PariService.Code.Handlers;

namespace PariService.Helpers
{
    public static class CommandHandlers
    {
        public static Type GetHandler(this string commandName)
        {
            return CommandHandlersList()[commandName];
        }

        private static Dictionary<string, Type> CommandHandlersList()
        {
            return new Dictionary<string, Type>
            {
                { "CreatePari", typeof(CreatePariHandler) }
            };
        }
    }
}