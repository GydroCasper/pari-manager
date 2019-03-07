using System.Collections.Generic;
using System.Threading.Tasks;
using PariService.Dto;

namespace PariMan.Lambda.GetList.Interfaces
{
    public interface IRun
    {
        Task<List<PariItem>> Run();
    }
}