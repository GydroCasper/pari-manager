using System.Collections.Generic;
using System.Threading.Tasks;
using PariService.Dto;

namespace PariService.Interfaces
{
    public interface IPariList
    {
        Task<List<PariItem>> Get();
    }
}