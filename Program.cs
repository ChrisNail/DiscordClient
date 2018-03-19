using Discord;
using Discord.API;
using Discord.API.Service;
using System;

namespace NailGamePlus {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Starting RePlayBot");
            Console.Write("Enter Token: ");
            string token = Console.ReadLine();

            DiscordClient client = new DiscordClient(token);

            Guild guild = new Guild();
            guild.name = "New Name";

            GuildService.ModifyGuild(client, "268831414634545152", guild);

            while(true) {

            }

        }
    }
}
