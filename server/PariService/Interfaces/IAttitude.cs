using System;
using System.Threading.Tasks;
using PariService.Dto;

namespace PariService.Interfaces
{
    public interface IAttitude
    {
        Task<Guid> Create(AttitudeItem attitude, Guid pariId);
    }
}