using System;
using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace DiscordBot
{
    class Program
    {
        private DiscordSocketClient _client;
        private LoggingService _log; 
        public static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _client.Log += log; 
            _client.MessageReceived += MessageReceived;
            
            var token = File.ReadAllText("token.txt");

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            await Task.Delay(-1);
        }

        private async Task MessageReceived(SocketMessage message)
        {
            if (message.Content == "!ping")
            {
                await message.Channel.SendMessageAsync("Pong!");
            }
        }

        private Task log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
	        return Task.CompletedTask;
        }
    }
}