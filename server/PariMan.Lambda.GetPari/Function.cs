using System;
using System.Collections.Generic;
using Amazon.Lambda.Core;
using PariService.Dto;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace PariMan.Lambda.GetPari
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="item"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public PariItem FunctionHandler(PariItem item, ILambdaContext context)
        {
            return new PariItem
            {
                Name = "Наебнуть СБТ",
                Attitudes = new List<Attitude>
                {
                    new Attitude {Id = Guid.Empty, Description = "123", Bettors = new List<string> {"Вася", "Петя"}, Name = "Позиция 1"},
                    new Attitude {Id = Guid.Empty, Name = "Позиция 2", Description = "abc", Bettors = new List<string> {"Магомед"}}
                }
            };
        }
    }
}
