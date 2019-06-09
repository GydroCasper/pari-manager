using System;
using System.Threading.Tasks;

namespace PariService.Interfaces
{
    public interface ICommandHandler
    {
        Task<Guid> Handle(object body);
    }
}