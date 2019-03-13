using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using PariService.Dto;
using PariService.Interfaces;
#pragma warning disable 1998

namespace PariService.Code.Handlers
{
    public class CreatePariHandler: ICommandHandler
    {
        private readonly IPari _pari;

        public CreatePariHandler(IPari pari)
        {
            _pari = pari;
        }

        public async Task<Guid> Handle(object body)
        {
            if(body == null) throw new PariException("Bet is empty");
            return await _pari.Create((body as JObject)?.ToObject<PariItem>());
        }
    }
}