using System.Collections.Generic;
using System.Threading.Tasks;
using PariMan.Lambda.GetList.Interfaces;
using PariService.Dto;
using PariService.Interfaces;

namespace PariMan.Lambda.GetList.Code
{
    public class App: IRun
    {
        private readonly IPariList _pariList;

        public App(IPariList pariList)
        {
            _pariList = pariList;
        }

        public async Task<List<PariItem>> Run()
        {
            return await _pariList.Get();
        }
    }
}
