using Amazon.Lambda.Core;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Template
{
    public class Function(IServiceProvider serviceProvider)
    {
        public Function() : this(Startup.ConfigureServices()) { }

        public async Task<string> FunctionHandler(string request, ILambdaContext context)
        {
            return request.ToUpper();
        }
    }
}
