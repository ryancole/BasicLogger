using System;
using System.IO;
using System.Text;
using System.Reflection;

namespace BasicLogger
{
    public class Logging
    {
        public static void WriteLine(string p_format, params object[] p_args)
        {
            // get the directory path containing this library
            string libraryLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // make note of the date to be used in the log file name
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            // format a log file name using current date
            string logName = string.Format("{0}-{1}.log", Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().CodeBase), date);

            // format a complete log file path
            string logLocation = Path.Combine(libraryLocation, "logs", logName);

            // create the containing directory just in case it doesn't exist
            Directory.CreateDirectory(Path.GetDirectoryName(logLocation));

            // prefix the log message with date, and suffix with newline
            string logLine = string.Format("[{0}] {1}{2}", DateTime.Now, string.Format(p_format, p_args), Environment.NewLine);

            // create the log file if it does not exist
            if (File.Exists(logLocation))
            {
                // append the formatted text to the log file
                File.AppendAllText(logLocation, logLine, Encoding.UTF8);
            }
            else
            {
                // write the formatted text to the log file
                File.WriteAllText(logLocation, logLine, Encoding.UTF8);
            }
        }
    }
}