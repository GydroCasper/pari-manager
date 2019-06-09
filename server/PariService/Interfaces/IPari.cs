using System;
using System.Threading.Tasks;
using PariService.Dto;

namespace PariService.Interfaces
{
    public interface IPari
    {
        Task<PariItem> Get(Guid? id);

        Task<Guid> Create(PariItem pari);
    }
}