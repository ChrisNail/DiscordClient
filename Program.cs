using Discord;
using Discord.API.Library;
using System;
using Discord.API.Rest;

namespace NailGamePlus {

    class Program {

        static void Main(string[] args) {
            Console.Write("Enter Token: ");
            string token = Console.ReadLine();

            DiscordClient.setToken(token);

            Guild[] guilds = UserService.getCurrentUserGuilds().Result;

            Channel[] channels = GuildService.getGuildChannels(guilds[0].id).Result;

            string channelId = null;
            foreach (Channel c in channels) {
                if(c.name.Equals("botcommands")) {
                    channelId = c.id;
                }
            }

            if (channelId != null) {
                Message[] messages = ChannelService.getChannelMessages(channelId, null, null, null, 2).Result;
                Console.WriteLine(messages[0].content);
                BulkDeleteMessageParams messageParams = new BulkDeleteMessageParams();
                messageParams.messages = new string[] { messages[0].id, messages[1].id };
                bool result = ChannelService.bulkDeleteMessages(channelId, messageParams).Result;
                Console.WriteLine("Success: " + result);
            }

            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
