using Newtonsoft.Json;
using System.Threading.Tasks;
using Discord.API.Library;
using System.Collections.Generic;

namespace Discord.API.Rest {

    public class ChannelService {

        /**
         * Get a Channel.
         */
        public static async Task<Channel> getChannel(string channelId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId);

            string result = await DiscordClient.getAsync(url);

            Channel channel = null;
            if (result != null) {
                channel = JsonConvert.DeserializeObject<Channel>(result);
            }

            return channel;
        }

        /**
         * Modify a Channel.
         */
        public static async Task<Channel> modifyChannel(string channelId, ModifyChannelParams channelParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId);

            string result = await DiscordClient.patchAsync(url, null, channelParams);

            Channel channel = null;
            if (result != null) {
                channel = JsonConvert.DeserializeObject<Channel>(result);
            }

            return channel;
        }

        /**
         * Delete a Channel.
         */
        public static async Task<Channel> deleteChannel(string channelId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId);

            string result = await DiscordClient.deleteAsync(url);

            Channel channel = null;
            if (result != null) {
                channel = JsonConvert.DeserializeObject<Channel>(result);
            }

            return channel;
        }

        /**
         * Get a list of the most recent Messages from a Channel.
         */
        public static async Task<Message[]> getChannelMessages(string channelId, string around = null, string before = null, string after = null, int? limit = null) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES;
            Dictionary<string, object> queryList = new Dictionary<string, object>() {
                { "around", around },
                { "before", before },
                { "after", after },
                { "limit", limit },
            };

            string result = await DiscordClient.getAsync(url, queryList);

            Message[] messages = null;
            if (result != null) {
                messages = JsonConvert.DeserializeObject<Message[]>(result);
            }

            return messages;
        }

        /**
         * Get a Channel Message.
         */
        public static async Task<Message> getChannelMessage(string channelId, string messageId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES + string.Format(Endpoints.PARAMETER, messageId);

            string result = await DiscordClient.getAsync(url);

            Message message = null;
            if (result != null) {
                message = JsonConvert.DeserializeObject<Message>(result);
            }

            return message;
        }

        /**
         * Create a new Message.
         */
        public static async Task<Message> createMessage(string channelId, CreateMessageParams messageParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES;

            string result = await DiscordClient.postAsync(url, null, messageParams);

            Message message = null;
            if (result != null) {
                message = JsonConvert.DeserializeObject<Message>(result);
            }

            return message;
        }

        /**
         * Create a Reaction to a Message.
         */
        public static async Task<bool> createReaction(string channelId, string messageId, string emojiCode) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES + string.Format(Endpoints.PARAMETER, messageId)
                + Endpoints.REACTIONS + string.Format(Endpoints.PARAMETER, emojiCode)
                + Endpoints.CURRENT_USER;

            string result = await DiscordClient.putAsync(url);

            bool success = false;
            if (result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Delete current User's reaction on a Message.
         */
        public static async Task<bool> deleteOwnReaction(string channelId, string messageId, string emojiCode) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES + string.Format(Endpoints.PARAMETER, messageId)
                + Endpoints.REACTIONS + string.Format(Endpoints.PARAMETER, emojiCode)
                + Endpoints.CURRENT_USER;

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if (result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Delete a User's reaction on a Message.
         */
        public static async Task<bool> deleteReaction(string channelId, string messageId, string emojiCode, string userId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES + string.Format(Endpoints.PARAMETER, messageId)
                + Endpoints.REACTIONS + string.Format(Endpoints.PARAMETER, emojiCode)
                + string.Format(Endpoints.PARAMETER, userId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if (result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get a list of Users who reacted using a specific emoji to a Message.
         */
        public static async Task<User[]> getReactions(string channelId, string messageId, string emojiCode, string before = null, string after = null, int? limit = null) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES + string.Format(Endpoints.PARAMETER, messageId)
                + Endpoints.REACTIONS + string.Format(Endpoints.PARAMETER, emojiCode);
            Dictionary<string, object> queryList = new Dictionary<string, object>() {
                { "before", before },
                { "after", after },
                { "limit", limit }
            };

            string result = await DiscordClient.getAsync(url, queryList);

            User[] users = null;
            if (result != null) {
                users = JsonConvert.DeserializeObject<User[]>(result);
            }

            return users;
        }

        /**
         * Delete all Reactions to a Message.
         */
        public static async Task<bool> deleteAllReactions(string channelId, string messageId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES + string.Format(Endpoints.PARAMETER, messageId)
                + Endpoints.REACTIONS;

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if (result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Edit an existing Message.
         */
        public static async Task<Message> editMessage(string channelId, string messageId, EditMessageParams messageParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES + string.Format(Endpoints.PARAMETER, messageId);

            string result = await DiscordClient.patchAsync(url, null, messageParams);

            Message message = null;
            if (result != null) {
                message = JsonConvert.DeserializeObject<Message>(result);
            }

            return message;
        }

        /**
         * Delete a Message.
         */
        public static async Task<bool> deleteMessage(string channelId, string messageId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES + string.Format(Endpoints.PARAMETER, messageId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if (result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Bulk delete Messages from a Channel.
         */
        public static async Task<bool> bulkDeleteMessages(string channelId, BulkDeleteMessageParams messageParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.MESSAGES + Endpoints.BULK_DELETE;

            string result = await DiscordClient.deleteAsync(url, null, messageParams);

            bool success = false;
            if (result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Modify a Channel's permission overwrites for a User or Role.
         */
        public static async Task<bool> editChannelPermissions(string channelId, string overwriteId, ModifyChannelPermissionParams permissionParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.PERMISSIONS + string.Format(Endpoints.PARAMETER, overwriteId);

            string result = await DiscordClient.putAsync(url, null, permissionParams);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get a list of Invites for a Guild Channel.
         * Requires  the "MANAGE_CHANNELS" permission.
         */
        public static async Task<Invite[]> getChannelInvites(string channelId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.INVITES;

            string result = await DiscordClient.getAsync(url);

            Invite[] invites = null;
            if(result != null) {
                invites = JsonConvert.DeserializeObject<Invite[]>(result);
            }

            return invites;
        }

        /**
         * Create an instant Guild Channel Invite.
         */
        public static async Task<Invite> createChannelInvite(string channelId, CreateInviteParams inviteParams) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.INVITES;

            string result = await DiscordClient.postAsync(url, null, inviteParams);

            Invite invite = null;
            if(result != null) {
                invite = JsonConvert.DeserializeObject<Invite>(result);
            }

            return invite;
        }

        /**
         * Delete a Guild Channel permission overwrite for a User or Role.
         */
        public static async Task<bool> deleteChannelPermission(string channelId, string overwriteId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.PERMISSIONS + string.Format(Endpoints.PARAMETER, overwriteId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Trigger the typing indicator in a Channel for this User.
         */
        public static async Task<bool> triggerTypingIndicator(string channelId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.TYPING;

            string result = await DiscordClient.postAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Get a list of pinned Messages.
         */
        public static async Task<Message[]> getPinnedMessages(string channelId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.PINS;

            string result = await DiscordClient.getAsync(url);

            Message[] messages = null;
            if(result != null) {
                messages = JsonConvert.DeserializeObject<Message[]>(result);
            }

            return messages;
        }

        /**
         * Pin a Message on a Guild Channel.
         */
        public static async Task<bool> addPinnedChannelMessage(string channelId, string messageId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.PINS + string.Format(Endpoints.PARAMETER, messageId);

            string result = await DiscordClient.putAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }

        /**
         * Remove a Message from being pinned in a Guild Channel. 
         */
        public static async Task<bool> deletePinnedChannelMessage(string channelId, string messageId) {
            string url = DiscordClient.BASE_URL
                + Endpoints.CHANNELS + string.Format(Endpoints.PARAMETER, channelId)
                + Endpoints.PINS + string.Format(Endpoints.PARAMETER, messageId);

            string result = await DiscordClient.deleteAsync(url);

            bool success = false;
            if(result != null) {
                success = true;
            }

            return success;
        }
    }
}