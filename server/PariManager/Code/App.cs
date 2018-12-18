using System.Threading.Tasks;
using PariManager.Interfaces;
using PariService.Interfaces;

namespace PariManager.Code
{
    public class App : IGet
    {
        private readonly IPariList _pariList;

        public App(IPariList pariList)
        {
            _pariList = pariList;
        }

        public async Task<object> Get()
        {
            return await _pariList.Get();
        }
    }
}