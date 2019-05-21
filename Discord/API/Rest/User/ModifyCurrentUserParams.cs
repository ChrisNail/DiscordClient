using Newtonsoft.Json;

namespace Discord.API.Rest {

    /**
     * Parameters to modify the current User.
     */
    public class ModifyCurrentUserParams {

        /**
         * Users new username.
         * Between 2 and 32 characters long.
         */
        [JsonProperty("username")]
        public string username;

        /**
         * Avatar data.
         * Data URI scheme: data:image/jpeg;base64,BASE64_ENCODED_JPEG_IMAGE_DATA
         * Supports jpeg, png, and gif.
         */
        [JsonProperty("avatar")]
        public string avatar;
    }
}
