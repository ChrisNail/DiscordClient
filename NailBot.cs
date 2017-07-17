using Discord;
using Discord.Commands;
using Discord.Audio;
using Discord.Modules;
using Discord.Commands.Permissions.Levels;
using System.Threading.Tasks;
using System.Text;
using System.Diagnostics;

using System;

namespace NailDiscordBot {

    public class NailBot {

        public static DiscordClient discordClient;

        Server replayServer;

        CommandService commands;

        IAudioClient audio;

        ModuleService modules;

        public NailBot() {

            discordClient = new DiscordClient(x => {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = log;
            });

            setupCommands();

            setupVoice();

            modules = discordClient.AddService<ModuleService>();
            discordClient.UsingPermissionLevels(PermissionResolver);
            //discordClient.AddModule<ColorsModule>("Color Module", ModuleFilter.None);

            Console.WriteLine("Enter Discord Bot App Token");
            String clientKey = Console.ReadLine();
            discordClient.ExecuteAndWait(async () => {
                await discordClient.Connect(clientKey, TokenType.Bot);
            });

        }

        private void setupCommands() {
            discordClient.UsingCommands(x => {
                x.PrefixChar = '!';
                x.AllowMentionPrefix = true;
            });

            commands = discordClient.GetService<CommandService>();

            //Simple "Hello" Command
            commands.CreateCommand("hello").Do(
                async (e) => {
                    await e.Channel.SendMessage("Hello " + e.User.Name + "!");
                });

            commands.CreateCommand("mock").Parameter("user", ParameterType.Optional).Do(
                (e) => {
                    mock(e.Channel, e.GetArg(0));
                });

            //Join Voice Channel
            commands.CreateCommand("join").Parameter("voiceChannel", ParameterType.Required).Do(
                async (e) => {
                    audio = await joinVoiceChannel(e.Server, e.GetArg("voiceChannel"));
                });

            //Shutdown Bot
            commands.CreateCommand("shutdown").Do(
                async (e) => {
                    Message m = await e.Channel.SendMessage("Goodbye, cruel world!");
                    Console.WriteLine(m.Text);
                    await discordClient.Disconnect();
                    Environment.Exit(0);
                });

            addSimpleReplyCommand("thanks", "I gotchu, fam.");

            Console.WriteLine("Commands Setup Complete");
        }

        private void setupVoice() {
            discordClient.UsingAudio(x => {
                x.Mode = AudioMode.Outgoing;
            });

            Console.WriteLine("Audio Setup Complete");
        }

        private Channel findVoiceChannel(Server server, string channelName) {
            Channel audioChannel = null;

            if (server != null) {
                foreach (Channel c in server.VoiceChannels) {
                    if (c.Name.Equals(channelName)) {
                        audioChannel = c;
                        break;
                    }
                }
                Console.WriteLine("Channel Does Not Exist");
            } else {
                Console.WriteLine("Server Does Not Exist");
            }
            return audioChannel;
        }

        private Task<IAudioClient> joinVoiceChannel(Server server, string channelName) {
            return discordClient.GetService<AudioService>().Join(findVoiceChannel(server, channelName));
        }

        private Task leaveVoiceChannel(Server server, string channelName) {
            audio = null;
            return discordClient.GetService<AudioService>().Leave(findVoiceChannel(server, channelName));
        }

        public void addSimpleReplyCommand(string call, string response) {
            commands.CreateCommand(call).Do(
                async (e) => {
                    await e.Channel.SendMessage(response);
                });
        }

        public async void mock(Channel c, string user) {
            Message[] messages = await c.DownloadMessages(5);
            Message lastMessage = messages[1];
            foreach (Message m in messages) {
                if (m.User.Name.Equals(user)) {
                    lastMessage = m;
                }
            }
            bool isCaps = false;
            StringBuilder mock = new StringBuilder();
            foreach (char character in lastMessage.Text.ToCharArray()) {
                if (Char.IsLetter(character)) {
                    if (isCaps) {
                        mock.Append(Char.ToUpper(character));
                    } else {
                        mock.Append(Char.ToLower(character));
                    }
                    isCaps = !isCaps;
                } else {
                    mock.Append(character);
                }
            }
            await c.SendMessage(mock.ToString() + "\n" + Images.mockingSpongeBob);
        }

        private int PermissionResolver(User user, Channel channel) {
            if (user.Id == Settings.DevId) {
                return (int)PermissionLevel.BotOwner;
            }
            if (user.Server != null) {
                if (user == channel.Server.Owner) {
                    return (int)PermissionLevel.ServerOwner;
                }
                var serverPerms = user.ServerPermissions;
                if (serverPerms.ManageRoles)
                    return (int)PermissionLevel.ServerAdmin;
                if (serverPerms.ManageMessages && serverPerms.KickMembers && serverPerms.BanMembers)
                    return (int)PermissionLevel.ServerModerator;

                var channelPerms = user.GetPermissions(channel);
                if (channelPerms.ManagePermissions)
                    return (int)PermissionLevel.ChannelAdmin;
                if (channelPerms.ManageMessages)
                    return (int)PermissionLevel.ChannelModerator;
            }
            return (int)PermissionLevel.User;
        }

        private void log(object sender, LogMessageEventArgs e) {
            Console.WriteLine($"[{e.Severity}] {e.Source}: {e.Message}");
        }

        
    }

    public class Images {

        public const string mockingSpongeBob = "http://i.imgur.com/iVwzaFJ.png";
    }
}