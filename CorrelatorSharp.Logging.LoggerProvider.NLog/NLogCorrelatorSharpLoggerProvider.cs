using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;

namespace CorrelatorSharp.Logging.LoggerProvider.NLog
{
    [ProviderAlias("CorrelatorSharp.NLog")]
    [ExcludeFromCodeCoverage]
    public class NLogCorrelatorSharpLoggerProvider : CorrelatorSharpLoggerProvider
    {
        public NLogCorrelatorSharpLoggerProvider() : base(new NLogScopeProvider())
        {
            LoggingConfiguration.Current.UseNLog();
        }
    }
}