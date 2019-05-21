using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    /**
     * Channel Message object.
     */
    public class Message {

        /**
         * Message Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Channel Snowflake ID.
         */
        [JsonProperty("channel_id")]
        public string channelId;

        /**
         * Author User object.
         */
        [JsonProperty("author")]
        public User author;

        /**
         * Message contents.
         */
        [JsonProperty("content")]
        public string content;

        /**
         * Message timestamp.
         */
        [JsonProperty("timestamp")]
        public string timestamp;

        /**
         * Message edited timestamp.
         */
        [JsonProperty("edited_timestamp")]
        public string editedTimestamp;

        /**
         * Is TTS Message.
         */
        [JsonProperty("tts")]
        public bool? textToSpeech;

        /**
         * Does Message mention everyone.
         */
        [JsonProperty("mention_everyone")]
        public bool? mentionEveryone;

        /**
         * List of partial User objects mentioned.
         */
        [JsonProperty("mentions")]
        public User[] userMentions;

        /**
         * List of partial Role objects mentioned.
         */
        [JsonProperty("mention_roles")]
        public Role[] roleMentions;

        /**
         * List of Attachment objects.
         */
        [JsonProperty("attachments")]
        public Attachment[] attachments;

        /**
         * List of Embed objects.
         */
        [JsonProperty("embeds")]
        public Embed[] embeds;

        /**
         * List of reactions to Message.
         */
        [JsonProperty("reactions")]
        public Reaction[] reactions;

        /**
         * Used for validating a message was sent.
         */
        [JsonProperty("nonce")]
        public string nonce;


        /**
         * Is Messaged pinned.
         */
        [JsonProperty("pinned")]
        public bool? pinned;

        /**
         * Webhook Snowflake ID.
         */
        [JsonProperty("webhook_id")]
        public string webhookId;

        /**
         * Message type.
         */
        [JsonProperty("type")]
        public int? type;

        /**
         * Message Activity sent with Rich Presence-related chat embed.
         */
        [JsonProperty("activity")]
        public MessageActivity messageActivity;

        /**
         * Message Application sent with Rich Presence-related chat embed.
         */
        [JsonProperty("application")]
        public MessageApplication messageApplication;
    }

    enum MessageType {
        DEFAULT = 0,
        RECIPIENT_ADD = 1,
        RECIPIENT_REMOVE = 2,
        CALL = 3,
        CHANNEL_NAME_CHANGE = 4,
        CHANNEL_ICON_CHANGE = 5,
        CHANNEL_PINNED_MESSAGE = 6,
        GUILD_MEMBER_JOIN = 7
    }
}
