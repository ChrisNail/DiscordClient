using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Specialized;
using System;
using System.Reflection;
using System.Collections.Generic;

namespace Discord {
    public static class DiscordClient {

        public static readonly string BASE_URL = "https://discordapp.com/api/v6";

        /**
         * PATCH HttpMethod type.
         */
        public static readonly HttpMethod PATCH = new HttpMethod("PATCH");

        /**
         * Discord API Bot token
         */
        private static string token;

        /**
         * The HttpClient to make calls with
         */
        private static HttpClient client = new HttpClient();

        /**
         * Sets the Discord API Token for a Bot.
         */
        public static void setToken(string token) {
            DiscordClient.token = token;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bot", token);
        }

        /**
         * Make a GET call to the given URL.
         */
        public static async Task<string> getAsync(string url, Dictionary<string, object> queryList = null) {
            string urlQuery = url;
            if (queryList != null) {
                urlQuery += getQueryString(queryList);
            }

            HttpResponseMessage response = await client.GetAsync(urlQuery);

            string result = null;
            if (response.IsSuccessStatusCode) {
                result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }


        public static async Task<string> putAsync(string url, Dictionary<string, object> queryList = null, object parameters = null) {
            string urlQuery = url;
            if(queryList != null) {
                urlQuery += getQueryString(queryList);
            }

            string jsonParameters = JsonConvert.SerializeObject(
                parameters,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
            );
            StringContent content = new StringContent(jsonParameters, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync(urlQuery, content);

            string result = null;
            if(response.IsSuccessStatusCode) {
                result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }


        public static async Task<string> postAsync(string url, Dictionary<string, object> queryList = null, object parameters = null) {
            string urlQuery = url;
            if(queryList != null) {
                urlQuery += getQueryString(queryList);
            }

            string jsonParameters = JsonConvert.SerializeObject(
                parameters,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
            );
            StringContent content = new StringContent(jsonParameters, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(urlQuery, content);

            string result = null;
            if(response.IsSuccessStatusCode) {
                result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }

        /**
         * Make a PATCH call to the given URL with parameters.
         */
        public static async Task<string> patchAsync(string url, Dictionary<string, object> queryList = null, object parameters = null) {
            string urlQuery = url;
            if(queryList != null) {
                urlQuery += getQueryString(queryList);
            }

            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), urlQuery);
            string jsonParameters = JsonConvert.SerializeObject(
                parameters, 
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
            );
            request.Content = new StringContent(jsonParameters, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.SendAsync(request);

            string result = null;
            if (response.IsSuccessStatusCode) {
                result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }


        public static async Task<string> deleteAsync(string url, Dictionary<string, object> queryList = null, object parameters = null) {
            string urlQuery = url;
            if(queryList != null) {
                urlQuery += getQueryString(queryList);
            }

            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("DELETE"), urlQuery);
            string jsonParameters = JsonConvert.SerializeObject(
                parameters,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
            );
            request.Content = new StringContent(jsonParameters, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.SendAsync(request);

            string result = null;
            if(response.IsSuccessStatusCode) {
                result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }


        public static string getQueryString(Dictionary<string, object> queryList) {
            string query = "?";
            foreach (KeyValuePair<string, object> keyValue in queryList) {
                if (keyValue.Value != null) {
                    query += string.Format("{0}={1}&", keyValue.Key, keyValue.Value);
                }
            }

            return query.Substring(0, query.Length - 1);
        }
    }
}
