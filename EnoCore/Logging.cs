﻿using EnoCore.Models.Json;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EnoCore
{
    public class EnoLogger
    {
        private readonly string Tool;

        public EnoLogger(string tool)
        {
            Tool = tool;
        }

        public void LogTrace(EnoLogMessage message)
        {
            message.Severity = "TRACE";
            Log(message);
        }

        public void LogDebug(EnoLogMessage message)
        {
            message.Severity = "DEBUG";
            Log(message);
        }

        public void LogInfo(EnoLogMessage message)
        {
            message.Severity = "INFO";
            Log(message);
        }

        public void LogWarning(EnoLogMessage message)
        {
            message.Severity = "WARNING";
            Log(message);
        }

        public void LogError(EnoLogMessage message)
        {
            message.Severity = "ERROR";
            Log(message);
        }

        public void LogFatal(EnoLogMessage message)
        {
            message.Severity = "FATAL";
            Log(message);
        }

        private void Log(EnoLogMessage message)
        {
            message.Tool = Tool;
            message.Timestamp = DateTime.Now.ToString(); //TODO chose a date format
            Console.WriteLine(JsonConvert.SerializeObject(message));
        }
    }
}
