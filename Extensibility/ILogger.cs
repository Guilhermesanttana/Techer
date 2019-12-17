using System;
using System.Collections.Generic;
using System.Text;

namespace Extensibility
{
    public interface ILogger
    {
        string Teste { get; set; }
        void LogError(string message);
        void LogInfo(string message);
    }
}
