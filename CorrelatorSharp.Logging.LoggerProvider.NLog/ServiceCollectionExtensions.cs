using CorrelatorSharp.Logging.LoggerProvider.NLog;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CorrelatorSharp.Logging
{
    public static class ServiceCollectionExtensions
    {
        public static void UseCorrelatorSharpNLogLoggerProvider(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ILoggerProvider>(new NLogCorrelatorSharpLoggerProvider());
        }
    }
}
