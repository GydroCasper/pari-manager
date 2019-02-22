using System.Collections.Generic;
using Amazon.Lambda.Core;
using PariService.Dto;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace PariMan.Lambda.GetList
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<PariItem> FunctionHandler(object input, ILambdaContext context)
        {
            return new List<PariItem>
            {
                new PariItem { Name = "Отдать нахер все острова"},
                new PariItem { Name = "Отпетушарить Мамаева и Кокорина"}
            };
        }
    }
}
