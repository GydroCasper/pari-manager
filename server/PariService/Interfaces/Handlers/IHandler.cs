using System.Threading.Tasks;

namespace PariService.Interfaces.Handlers
{
    public interface IHandler
    {
        Task<object> ExecuteQuery(object query);
    }
}