using System;
using System.Threading.Tasks;
using PariService.Interfaces;
#pragma warning disable 1998

namespace PariService.Code.Handlers
{
    public class CreatePariHandler: ICommandHandler
    {
        public async Task<Guid> Handle(object body)
        {
            Console.WriteLine("Handler working");
            return Guid.Empty;
        }
    }
}