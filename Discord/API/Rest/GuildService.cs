using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Discord.API.Library;
using System.Collections.Generic;

namespace Discord.API.Rest {

    public class GuildService {

        /**
         * Create a new Guild.
         */
        public static async Task<Guild> createGuild(CreateGuildParameters guildParams) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS;

            string result = await DiscordClient.postAsync(url, null, guildParams);

            Guild guild = null;
            if (result != null) {
                guild = JsonConvert.DeserializeObject<Guild>(result);
            }

            return guild;
        }

        /**
         * Get a Guild by Snowflake ID.
         */
        public static async Task<Guild> getGuild(string guildId) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId);

            string result = await DiscordClient.getAsync(url);

            Guild guild = null;
            if (result != null) {
                guild = JsonConvert.DeserializeObject<Guild>(result);
            }

            return guild;
        }

        /**
         * Modify a Guild.
         */
        public static async Task<Guild> modifyGuild(string guildId, ModifyGuildParams guildParams) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId);

            string result = await DiscordClient.patchAsync(url, null, guildParams);

            Guild guild = null;
            if (result != null) {
                guild = JsonConvert.DeserializeObject<Guild>(result);
            }

            return guild;
        }

        /**
         * Delete a Guild.
         */
        public static async Task<bool> deleteGuild(string guildId) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if (result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get the Channels from a Guild.
         */
        public static async Task<Channel[]> getGuildChannels(string guildId) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId) 
                + Endpoints.CHANNELS;

            string result = await DiscordClient.getAsync(url);

            Channel[] channels = null;
            if (result != null) {
                channels = JsonConvert.DeserializeObject<Channel[]>(result);
            }

            return channels;
        }

        /**
         * Create a Channel in a Guild.
         */
        public static async Task<Channel> createGuildChannel(string guildId, CreateChannelParams channelParams) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId) 
                + Endpoints.CHANNELS;

            string result = await DiscordClient.postAsync(url, null, channelParams);

            Channel channel = null;
            if (result != null) {
                channel = JsonConvert.DeserializeObject<Channel>(result);
            }

            return channel;
        }

        /**
         * Modify Guild Channel positions.
         */
        public static async Task<bool> modifyGuildChannelPositions(string guildId, ModifyChannelPositionParams[] channelPositionParams) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId) 
                + Endpoints.CHANNELS;

            string result = await DiscordClient.patchAsync(url, null, channelPositionParams);

            bool success = false;
            if (result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get a Guild Member.
         */
        public static async Task<GuildMember> getGuildMember(string guildId, string userId) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId) 
                + Endpoints.MEMBERS + string.Format(Endpoints.PARAMETER, userId);

            string result = await DiscordClient.getAsync(url);

            GuildMember member = null;
            if (result != null) {
                member = JsonConvert.DeserializeObject<GuildMember>(result);
            }

            return member;
        }

        /**
         * List all Guild Members.
         */
        public static async Task<GuildMember[]> listGuildMembers(string guildId, int? limit = null, string after = null) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId) 
                + Endpoints.MEMBERS;
            Dictionary<string, object> queryList = new Dictionary<string, object>() {
                { "limit", limit },
                { "after", after }
            };

            string result = await DiscordClient.getAsync(url, queryList);

            GuildMember[] members = null;
            if(result != null) {
                members = JsonConvert.DeserializeObject<GuildMember[]>(result);
            }

            return members;
        }

        /**
         * Add a User to a Guild.
         * Requires a valid oauth2 access token for the User with the guilds.join scope.
         */
        public static async Task<bool> addGuildMember(string guildId, string userId, AddGuildMemberParams guildMemberParams) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId) 
                + Endpoints.MEMBERS + string.Format(Endpoints.PARAMETER, userId);

            string result = await DiscordClient.putAsync(url, null, guildMemberParams);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Modify attributes of a Guild Member.
         */
        public static async Task<bool> modifyGuildMember(string guildId, string userId, ModifyGuildMemberParams guildMemberParams) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId) 
                + Endpoints.MEMBERS + string.Format(Endpoints.PARAMETER, userId);

            string result = await DiscordClient.patchAsync(url, null, guildMemberParams);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Modify the current User's nickname in a Guild.
         */
        public static async Task<GuildMember> modifyCurrentUserNick(string guildId, ModifyCurrentUserNickParams currentUserNickParams) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId) 
                + Endpoints.MEMBERS + Endpoints.CURRENT_USER + Endpoints.NICKNAME;

            string result = await DiscordClient.patchAsync(url, null, currentUserNickParams);

            GuildMember member = null;
            if(result != null) {
                member = JsonConvert.DeserializeObject<GuildMember>(result);
            }

            return member;
        }

        /**
         * Add a Guild Role to a Guild Member.
         */
        public static async Task<bool> addGuildMemberRole(string guildId, string userId, string roleId) {
            string url = DiscordClient.BASE_URL 
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId) 
                + Endpoints.MEMBERS + string.Format(Endpoints.PARAMETER, userId) 
                + Endpoints.ROLES + string.Format(Endpoints.PARAMETER, roleId);

            string result = await DiscordClient.putAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Remove a Guild Role from a Guild Member.
         */
        public static async Task<bool> removeGuildMemberRole(string guildId, string userId, string roleId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.MEMBERS + string.Format(Endpoints.PARAMETER, userId)
                + Endpoints.ROLES + string.Format(Endpoints.PARAMETER, roleId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Remove a Guild Member from a Guild.
         */
        public static async Task<bool> removeGuildMember(string guildId, string userId) {
            string url = DiscordClient.BASE_URL
               + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
               + Endpoints.MEMBERS + string.Format(Endpoints.PARAMETER, userId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get all Bans for a Guild.
         */
        public static async Task<GuildBan[]> getGuildBans(string guildId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.BANS;

            string result = await DiscordClient.getAsync(url);

            GuildBan[] bans = null;
            if(result != null) {
                bans = JsonConvert.DeserializeObject<GuildBan[]>(result);
            }

            return bans;
        }

        /**
         * Get a User's Guild Ban.
         */
        public static async Task<GuildBan> getGuildBans(string guildId, string userId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.BANS + string.Format(Endpoints.PARAMETER, userId);

            string result = await DiscordClient.getAsync(url);

            GuildBan ban = null;
            if(result != null) {
                ban = JsonConvert.DeserializeObject<GuildBan>(result);
            }

            return ban;
        }

        /**
         * Create a Guild Ban.
         */
        public static async Task<bool> createGuildBan(string guildId, string userId, int? deleteMessageDays, string reason) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.BANS + string.Format(Endpoints.PARAMETER, userId);
            Dictionary<string, object> queryList = new Dictionary<string, object>() {
                { "delete-message-days", deleteMessageDays },
                { "reason", reason }
            };

            string result = await DiscordClient.putAsync(url, queryList);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Remove a Guild Ban.
         */
        public static async Task<bool> removeGuildBan(string guildId, string userId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.BANS + string.Format(Endpoints.PARAMETER, userId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get a list of Guild Roles.
         */
        public static async Task<Role[]> getGuildRoles(string guildId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.ROLES;

            string result = await DiscordClient.getAsync(url);

            Role[] roles = null;
            if(result != null) {
                roles = JsonConvert.DeserializeObject<Role[]>(result);
            }

            return roles;
        }

        /**
         * Create a new Role for a Guild.
         */
        public static async Task<Role> createGuildRole(string guildId, CreateRoleParams roleParams) {
            string url = DiscordClient.BASE_URL
               + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
               + Endpoints.ROLES;

            string result = await DiscordClient.postAsync(url, null, roleParams);

            Role role = null;
            if(result != null) {
                role = JsonConvert.DeserializeObject<Role>(result);
            }

            return role;
        }

        /**
         * Modify Guild Role positions.
         */
        public static async Task<Role[]> modifyGuildRolePositions(string guildId, ModifyRolePositionParams[] rolePositionParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.ROLES;

            string result = await DiscordClient.patchAsync(url, null, rolePositionParams);

            Role[] roles = null;
            if(result != null) {
                roles = JsonConvert.DeserializeObject<Role[]>(result);
            }

            return roles;
        }

        /**
         * Modify a Guild Role.
         */
        public static async Task<Role> modifyGuildRole(string guildId, string roleId, ModifyRoleParams roleParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.ROLES + string.Format(Endpoints.PARAMETER, roleId);

            string result = await DiscordClient.patchAsync(url, null, roleParams);

            Role role = null;
            if(result != null) {
                role = JsonConvert.DeserializeObject<Role>(result);
            }

            return role;
        }

        /**
         * Delete a Guild Role.
         */
        public static async Task<bool> deleteGuildRole(string guildId, string roleId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.ROLES + string.Format(Endpoints.PARAMETER, roleId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get the number of Guild Members that would be pruned.
         */
        public static async Task<GuildPrune> getGuildPruneCount(string guildId, int? days = null) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.PRUNE;
            Dictionary<string, object> queryList = new Dictionary<string, object>() {
                { "days", days }
            };

            string result = await DiscordClient.getAsync(url, queryList);

            GuildPrune prune = null;
            if(result != null) {
                prune = JsonConvert.DeserializeObject<GuildPrune>(result);
            }

            return prune;
        }

        /**
         * Begin a prune of Guild Members.
         */
        public static async Task<GuildPrune> beginGuildPrune(string guildId, int? days = null, bool? computePruneCount = null) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.PRUNE;
            Dictionary<string, object> queryList = new Dictionary<string, object>() {
                { "days", days }
            };

            string result = await DiscordClient.postAsync(url, queryList);

            GuildPrune prune = null;
            if(result != null) {
                prune = JsonConvert.DeserializeObject<GuildPrune>(result);
            }

            return prune;
        }

        /**
         * Get a list of the available Voice Regions for a Guild.
         */
        public static async Task<VoiceRegion[]> getGuildVoiceRegions(string guildId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.REGIONS;

            string result = await DiscordClient.getAsync(url);

            VoiceRegion[] regions = null;
            if(result != null) {
                regions = JsonConvert.DeserializeObject<VoiceRegion[]>(result);
            }

            return regions;
        }

        /**
         * Get a list of Invites for the Guild.
         */
        public static async Task<Invite[]> getGuildInvites(string guildId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.INVITES;

            string result = await DiscordClient.getAsync(url);

            Invite[] invites = null;
            if(result != null) {
                invites = JsonConvert.DeserializeObject<Invite[]>(result);
            }

            return invites;
        }

        /**
         * Get a list of Guild Integrations.
         */
        public static async Task<GuildIntegration[]> getGuildIntegrations(string guildId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.INTEGRATIONS;

            string result = await DiscordClient.getAsync(url);

            GuildIntegration[] integrations = null;
            if(result != null) {
                integrations = JsonConvert.DeserializeObject<GuildIntegration[]>(result);
            }

            return integrations;
        }

        /**
         * Create an Integration for a Guild.
         */
        public static async Task<bool> createGuildIntegration(string guildId, CreateGuildIntegrationParams integrationParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.INTEGRATIONS;

            string result = await DiscordClient.postAsync(url, null, integrationParams);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Modify an Integration for a Guild.
         */
        public static async Task<bool> modifyGuildIntegration(string guildId, string integrationId, ModifyGuildIntegrationParams integrationParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.INTEGRATIONS + string.Format(Endpoints.PARAMETER, integrationId);

            string result = await DiscordClient.postAsync(url, null, integrationParams);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Delete an Integration from a Guild.
         */
        public static async Task<bool> deleteGuildIntegration(string guildId, string integrationId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.INTEGRATIONS + string.Format(Endpoints.PARAMETER, integrationId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Sync an Integration for a Guild.
         */
        public static async Task<bool> syncGuildIntegration(string guildId, string integrationId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.INTEGRATIONS + string.Format(Endpoints.PARAMETER, integrationId);

            string result = await DiscordClient.postAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get the Guild Embed.
         */
        public static async Task<GuildEmbed> getGuildEmbed(string guildId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.EMBED;

            string result = await DiscordClient.getAsync(url);

            GuildEmbed embed = null;
            if(result != null) {
                embed = JsonConvert.DeserializeObject<GuildEmbed>(result);
            }

            return embed;
        }

        /**
         * Modify the Embed for a Guild.
         */
        public static async Task<GuildEmbed> modifyGuildEmbed(string guildId, ModifyGuildEmbedParams embedParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.EMBED;

            string result = await DiscordClient.patchAsync(url, null, embedParams);

            GuildEmbed embed = null;
            if(result != null) {
                embed = JsonConvert.DeserializeObject<GuildEmbed>(result);
            }

            return embed;
        }

        /**
         * Get a Guild Embed Image.
         */
        public static async Task<string> getGuildEmbedImage(string guildId, string style = null) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.EMBED_PNG;
            Dictionary<string, object> queryList = new Dictionary<string, object>() {
                { "style", style }
            };

            string result = await DiscordClient.getAsync(url, queryList);

            string image = null;
            if(result != null) {
                image = JsonConvert.DeserializeObject<string>(result);
            }

            return image;
        }

        /**
         * Get a Guild Vanity URL.
         */
        public static async Task<Invite> getGuildVanityUrl(string guildId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.VANITY_URL;

            string result = await DiscordClient.getAsync(url);

            Invite invite = null;
            if(result != null) {
                invite = JsonConvert.DeserializeObject<Invite>(result);
            }

            return invite;
        }

        /**
         * Get a Guild Widget Image.
         */
        public static async Task<string> getGuildWidgetImage(string guildId, string style = null) {
            string url = DiscordClient.BASE_URL
                + Endpoints.GUILDS + string.Format(Endpoints.PARAMETER, guildId)
                + Endpoints.WIDGET_PNG;
            Dictionary<string, object> queryList = new Dictionary<string, object>() {
                { "style", style }
            };

            string result = await DiscordClient.getAsync(url, queryList);

            string image = null;
            if(result != null) {
                image = JsonConvert.DeserializeObject<string>(result);
            }

            return image;
        }
    }
}