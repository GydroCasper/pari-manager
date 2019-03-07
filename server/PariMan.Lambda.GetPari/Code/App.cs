using System.Collections.Generic;
using System.Threading.Tasks;
using PariMan.Lambda.GetPari.Interfaces;
using PariService.Dto;

namespace PariMan.Lambda.GetPari.Code
{
    public class App: IRun
    {
        public Task<List<PariItem>> Run()
        {
            return null;
        }
    }
}
