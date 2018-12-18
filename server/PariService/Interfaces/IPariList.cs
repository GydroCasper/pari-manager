using System.Threading.Tasks;

namespace PariService.Interfaces
{
    public interface IPariList
    {
        Task<object> Get();
    }
}