using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DSharpPlus;

namespace Saltbot.Discord
{
    public class Client
    {
        /// <summary>
        /// Local instance of the DSharpPlus API client
        /// </summary>
        private static DiscordClient _client;

        /// <summary>
        /// Constructor for a new Client()
        /// </summary>
        public Client()
        {
            DiscordConfig config = new DiscordConfig();
            config.Token = ConfigurationManager.AppSettings["discordToken"];
            config.TokenType = TokenType.Bot;
            _client = new DiscordClient(config);
        }

        /// <summary>
        /// Set up the Bot behaviours
        /// </summary>
        /// <returns></returns>
        public async Task Initialise()
        {
            await _client.ConnectAsync();

            _client.MessageCreated += async (e) =>
            {
                if (e.Message.Content.ToLower().StartsWith("ping"))
                    await e.Message.RespondAsync("pong!");
            };
        }
    }
}
