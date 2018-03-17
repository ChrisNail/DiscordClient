using Discord;
using System.Threading.Tasks;
using System.Text;
using System.Diagnostics;

using System;

namespace NailGamePlus {

    public class NailBot {

        public DiscordClient client;

        public NailBot() {
            Console.Write("Enter Token: ");
            string token = Console.ReadLine();

            client = new DiscordClient(token);

            while(true) {

            }
        }
    }
}