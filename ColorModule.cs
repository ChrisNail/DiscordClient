using Discord;
using Discord.Commands;
using Discord.Commands.Permissions.Levels;
using Discord.Modules;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NailDiscordBot {

    class ColorsModule : IModule {

        private class ColorDefinition {
            public string id;
            public string name;
            public Color color;
            public ColorDefinition(string name, Color color) {
                this.name = name;
                id = name.ToLowerInvariant();
                this.color = color;
            }
        }
        private readonly List<ColorDefinition> colorList;
        private readonly Dictionary<string, ColorDefinition> colorMap;
        private ModuleManager manager;
        private DiscordClient discordClient;

        public ColorsModule() {
            colorList = new List<ColorDefinition>()
            {
                new ColorDefinition("Blue", Color.Blue),
                new ColorDefinition("Teal", Color.Teal),
                new ColorDefinition("Gold", Color.Gold),
                new ColorDefinition("Green", Color.Green),
                new ColorDefinition("Purple", Color.Purple),
                new ColorDefinition("Orange", Color.Orange),
                new ColorDefinition("Magenta", Color.Magenta),
                new ColorDefinition("Red", Color.Red),
                new ColorDefinition("DarkBlue", Color.DarkBlue),
                new ColorDefinition("DarkTeal", Color.DarkTeal),
                new ColorDefinition("DarkGold", Color.DarkGold),
                new ColorDefinition("DarkGreen", Color.DarkGreen),
                new ColorDefinition("DarkMagenta", Color.DarkMagenta),
                new ColorDefinition("DarkOrange", Color.DarkOrange),
                new ColorDefinition("DarkPurple", Color.DarkPurple),
                new ColorDefinition("DarkRed", Color.DarkRed),
            };
            colorMap = colorList.ToDictionary(x => x.id);
        }

        void IModule.Install(ModuleManager man) {
            manager = man;
            discordClient = manager.Client;

            manager.CreateCommands("colors", group => {
                //group.SetAlias("colours"); //TODO: add group alias and absolute vs relative alias
                group.CreateCommand("list")
                    .Description("Gives a list of all available username colors.")
                    .Do(async e => {
                        string text = $"{Format.Bold("Available Colors:")}\n" + string.Join(", ", colorList.Select(x => '`' + x.name + '`'));
                        await discordClient.Reply(e, text);
                    });
                group.CreateCommand("set")
                    .Parameter("color")
                    .Description("Sets your username to a custom color.")
                    .Do(e => setColor(e, e.User, e.Args[0]));
                group.CreateCommand("set")
                    .Parameter("user")
                    .Parameter("color")
                    .MinPermissions((int)PermissionLevel.BotOwner)
                    .Description("Sets another user's name to a custom color.")
                    .Do(e => {
                        User user = e.Server.FindUsers(e.Args[0]).FirstOrDefault();
                        if (user == null)
                            return discordClient.ReplyError(e, "Unknown user");
                        return setColor(e, user, e.Args[1]);
                    });
                group.CreateCommand("clear")
                    .Description("Removes your username color, returning it to default.")
                    .Do(async e => {
                        if (!e.Server.CurrentUser.ServerPermissions.ManageRoles) {
                            await discordClient.ReplyError(e, "This command requires the bot have Manage Roles permission.");
                            return;
                        }
                        var otherRoles = getOtherRoles(e.User);
                        await e.User.Edit(roles: otherRoles);
                        await discordClient.Reply(e, $"Reset username color.");
                    });
            });
        }

        private IEnumerable<Role> getOtherRoles(User user)
            => user.Roles.Where(x => !colorMap.ContainsKey(x.Name.ToLowerInvariant()));

        private async Task setColor(CommandEventArgs e, User user, string colorName) {
            ColorDefinition color;
            if (!colorMap.TryGetValue(colorName.ToLowerInvariant(), out color)) {
                await discordClient.ReplyError(e, "Unknown color");
                return;
            }
            if (!e.Server.CurrentUser.ServerPermissions.ManageRoles) {
                await discordClient.ReplyError(e, "This command requires the bot have Manage Roles permission.");
                return;
            }
            Role role = e.Server.Roles.Where(x => x.Name == color.name).FirstOrDefault();
            if (role == null) {
                role = await e.Server.CreateRole(color.name);
                await role.Edit(permissions: ServerPermissions.None, color: color.color);
            }
            var otherRoles = getOtherRoles(user);
            await user.Edit(roles: otherRoles.Concat(new Role[] { role }));
            await discordClient.Reply(e, $"Set {user.Name}'s color to {color.name}");
        }
    }
}
