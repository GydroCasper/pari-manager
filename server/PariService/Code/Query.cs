using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PariService.Code.Handlers;
using PariService.Dto;
using PariService.Interfaces;
using PariService.Interfaces.Handlers;

namespace PariService.Code
{
    public class Query
    {
        private readonly IServiceProvider _serviceProvider;

        public Query()
        {
            _serviceProvider = BuildServiceProvider();
        }

        private static IServiceProvider BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IPariList, Pari>();
            serviceCollection.AddSingleton<IGetList, GetListHandler>();

            return serviceCollection.BuildServiceProvider();
        }

        public Task<object> Execute(QueryDto query)
        {
            var handlerInterface = Assembly.GetExecutingAssembly().GetTypes().Single(x => typeof(IHandler).IsAssignableFrom(x) && x.FullName.EndsWith($"I{query.Name}"));
            if(!(_serviceProvider.GetService(handlerInterface) is IHandler handler)) throw new Exception("Handler for query doesn't find");

            return handler.ExecuteQuery(query);
        }
    }
}