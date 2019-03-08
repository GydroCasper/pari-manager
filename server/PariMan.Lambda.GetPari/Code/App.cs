using System;
using System.Threading.Tasks;
using PariMan.Lambda.GetPari.Interfaces;
using PariService.Code;
using PariService.Dto;
using PariService.Interfaces;

namespace PariMan.Lambda.GetPari.Code
{
    public class App: IRun
    {
        private readonly IPari _pari;
        private readonly ILogger _logger;

        public App(IPari pari, ILogger logger)
        {
            _pari = pari;
            _logger = logger;
        }

        public Task<PariItem> Run(Guid? id)
        {
            try
            {
                if (!id.HasValue) throw new PariException("Id is empty");
                return _pari.Get(id.Value);
            }
            catch (Exception ex)
            {
                _logger.LogException(ex);
                return null;
            }
        }
    }
}
