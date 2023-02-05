using System;
using UnityEditor;
using UnityEditor.Timeline.Actions;
using UnityEngine;
namespace TheConsortium
{
    /// <summary>
    /// Options for global debug level
    /// </summary>
    public enum DebugLevel
    {
        Log = 1,
        Warning = 2,
        Error = 3,
    }

    public static class s_LogHandler
    {
        /// <summary>
        /// A property to set global debug level
        /// </summary>
        private static DebugLevel _debugLevel = DebugLevel.Log;

        /// <summary>
        /// Editor menu item to set debug level to Log at runtime
        /// </summary>
        [MenuItem("Debug/Set Level/Log")]
        private static void DebugLevelLog()
        {
            setDebugLevel(DebugLevel.Log);
        }

        /// <summary>
        /// Editor menu item to set debug level to Log at runtime
        /// </summary>
        [MenuItem("Debug/Set Level/Warining")]
        private static void DebugLevelWarining()
        {
            setDebugLevel(DebugLevel.Warning);
        }

        /// <summary>
        /// Editor menu item to set debug level to Log at runtime
        /// </summary>
        [MenuItem("Debug/Set Level/Error")]
        private static void DebugLevelError()
        {
            setDebugLevel(DebugLevel.Error);
        }

        /// <summary>
        /// Log a message to the console - if debug level is log
        /// </summary>
        /// <param name="LogMessage">Message to write to log</param>
        public static void Log(string LogMessage)
        {
            if (_debugLevel == DebugLevel.Log)
                Debug.Log(LogMessage);
        }

        /// <summary>
        /// Log a warning to the console - if debug level is warning or lower
        /// </summary>
        /// <param name="LogMessage">Message to write to log</param>
        public static void LogWarning(string LogMessage)
        {
            if (_debugLevel <= DebugLevel.Warning)
                Debug.LogWarning(LogMessage);
        }

        /// <summary>
        /// Log a error to the console
        /// </summary>
        /// <param name="LogMessage">Message to write to log</param>
        public static void LogError(string LogMessage)
        {
            Debug.LogError(LogMessage);
        }

        /// <summary>
        /// Sets debug level
        /// </summary>
        /// <param name="level">Debug level to set</param>
        public static void setDebugLevel(DebugLevel level)
        {
            _debugLevel = level;
            Debug.Log(String.Format("Debug level set to {0}", _debugLevel.ToString()));
        }
    }
}