using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.API.Rest {

    public class Endpoints {
        public static readonly string CURRENT_USER = "/@me";

        public static readonly string USERS = "/users";

        public static readonly string GUILDS = "/guilds";

        public static readonly string CHANNELS = "/channels";

        public static readonly string MESSAGES = "/messages";

        public static readonly string REACTIONS = "/reactions";

        public static readonly string MEMBERS = "/members";

        public static readonly string ROLES = "/roles";

        public static readonly string PERMISSIONS = "/permissions";

        public static readonly string BANS = "/bans";

        public static readonly string PRUNE = "/prune";

        public static readonly string REGIONS = "/regions";

        public static readonly string INVITES = "/invites";

        public static readonly string INTEGRATIONS = "/integrations";

        public static readonly string EMBED = "/embed";

        public static readonly string PINS = "/pins";

        public static readonly string BULK_DELETE = "/bulk-delete";

        public static readonly string VANITY_URL = "/vanity-url";

        public static readonly string WIDGET_PNG = "/widget.png";

        public static readonly string EMBED_PNG = "/embed.png";

        public static readonly string NICKNAME = "/nick";

        public static readonly string CONNECTIONS = "/connections";

        public static readonly string TYPING = "/typing";

        public static readonly string PARAMETER = "/{0}";
    }
}
