using NLog;
using Saltbot.Discord;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Saltbot.ConsoleApp
{
    class Startup
    {
        /// <summary>
        /// The logger for the application
        /// </summary>
        private static ILogger _log = LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Saltbot!");
            SetupLogSource();
            StartDiscordClient().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private static async Task StartDiscordClient()
        {
            var client = new Client();
            await client.Initialise();
            await Task.Delay(-1);
        }

        /// <summary>
        /// Sets up an Event Log Source if this is being run as Administrator. If it isn't, then it will alert the user that one needs to be created manually.
        /// </summary>
        private static void SetupLogSource()
        {
            try
            {
                ConfigurationErrorsException storedException = null;
                string eventLogSourceName = "Saltbot.ConsoleApp";
                try
                {
                    eventLogSourceName = ConfigurationManager.AppSettings["eventLogSourceName"];
                }
                catch (ConfigurationErrorsException cee)
                {
                    storedException = cee;
                }

                if (!EventLog.SourceExists(eventLogSourceName))
                {
                    EventLog.CreateEventSource(eventLogSourceName, "Application");
                    if (_log.IsInfoEnabled)
                    {
                        _log.Info($"Setting up event log source [{eventLogSourceName}] in Application event log.");
                    }
                }

                if (storedException != null && _log.IsErrorEnabled)
                {
                    _log.Error(storedException, "Error occurred while attempting to read event log source name from configuration. Source has been configured as default [Saltbot.ConsoleApp]");
                }
            }
            catch (SecurityException)
            {
                using (var form = new Error())
                {
                    form.ShowDialog();
                    Environment.Exit(0);
                }
            }
        }
    }
}
