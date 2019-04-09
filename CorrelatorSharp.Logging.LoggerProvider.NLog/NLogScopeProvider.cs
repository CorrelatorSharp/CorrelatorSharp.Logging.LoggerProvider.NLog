using System;
using NLog;
using NLog.Common;

namespace CorrelatorSharp.Logging.LoggerProvider.NLog
{
    public class NLogScopeProvider : IScopeProvider
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return NestedDiagnosticsLogicalContext.Push(state);
        }

        public void ErrorBuildingScope(Exception exception)
        {
            InternalLogger.Debug(exception, "Exception in BeginScope push NestedDiagnosticsLogicalContext");
        }
    }
}
