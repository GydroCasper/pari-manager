using System;
using System.Threading.Tasks;
using PariService.Dto;

namespace PariMan.Lambda.GetPari.Interfaces
{
    public interface IRun
    {
        Task<PariItem> Run(Guid? id);
    }
}