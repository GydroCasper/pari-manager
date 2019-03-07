using System.Threading.Tasks;
using PariService.Interfaces;
using PariService.Interfaces.Handlers;

namespace PariService.Code.Handlers
{
    public class GetListHandler : IGetList
    {
        private readonly IPariList _pariList;

        public GetListHandler(IPariList pariList)
        {
            _pariList = pariList;
        }

        public Task<object> ExecuteQuery(object query)
        {
            return null; //_pariList.Get();
        }
    }
}