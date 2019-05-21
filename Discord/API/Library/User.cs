using System;
using Newtonsoft.Json;

namespace Discord.API.Library {

    public class User {

        /**
         * User Snowflake ID.
         */
        [JsonProperty("id")]
        public string id;

        /**
         * Username.
         */
        [JsonProperty("username")]
        public string username;

        /**
         * User's 4-digit discord-tag
         */
        [JsonProperty("discriminator")]
        public string discriminator;

        /**
         * Avatar hash
         */
        [JsonProperty("avatar")]
        public string avatar;

        /**
         * Is User a bot.
         */
        [JsonProperty("bot")]
        public bool? bot;

        /**
         * Two factor enabled.
         */
        [JsonProperty("mfa_enabled")]
        public bool? mfaEnabled;

        /**
         * Is account verified.
         */
        [JsonProperty("verified")]
        public bool? verified;

        /**
         * User's email.
         */
        [JsonProperty("email")]
        public string email;

        /**
         * Flags on account.
         */
        [JsonProperty("flags")]
        public int? flags;

        /**
         * Type of Nitro subscription on user's account.
         */
        [JsonProperty("premium_type")]
        public int? premiumType;
    }

    enum UserFlag {
        NONE = 0,
        DISCORD_EMPLOYEE = 1<<0,
        DISCORD_PARTNER = 1<<1,
        HYPESQUAD_EVENTS = 1<<2,
        BUG_HUNTER = 1<<3,
        HOUSE_BRAVERY = 1<<6,
        HOUSE_BRILLIANCE = 1<<7,
        HOUSE_BALANCE = 1<<8,
        EARLY_SUPORTER = 1<<9
    }

    enum PremiumType {
        NITRO_CLASSIC = 1, NITRO = 2
    }
}
