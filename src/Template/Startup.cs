using Amazon;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Template;

[ExcludeFromCodeCoverage]
public class Startup
{
    public static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        return services.BuildServiceProvider();
    }
}
