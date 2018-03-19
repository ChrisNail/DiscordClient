using Newtonsoft.Json;
using System;

namespace Discord.API {

    [JsonObject("message")]
    public class Message {

        [JsonProperty("id")]
        public string id;

        [JsonProperty("channel_id")]
        public string channelId;

        [JsonProperty("author")]
        public User author;

        [JsonProperty("content")]
        public string content;

        [JsonProperty("timestamp")]
        public Int32 timestamp;

        [JsonProperty("edited_timestamp")]
        public Int32 editedTimestamp;

        [JsonProperty("tts")]
        public Boolean textToSpeech;

        [JsonProperty("mention_everyone")]
        public Boolean mentionEveryone;

        [JsonProperty("mentions")]
        public User[] userMentions;

        [JsonProperty("mention_roles")]
        public Role[] roleMentions;

        [JsonProperty("attachments")]
        public Attachment[] attachments;

        [JsonProperty("embeds")]
        public Embed[] embeds;

        [JsonProperty("reactions")]
        public Reaction[] reactions;

        [JsonProperty("nonce")]
        public string nonce;

        [JsonProperty("pinned")]
        public Boolean pinned;

        [JsonProperty("webhook_id")]
        public string webhookId;

        [JsonProperty("type")]
        public Int32 type;

        [JsonProperty("activity")]
        public MessageActivity messageActivity;

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
