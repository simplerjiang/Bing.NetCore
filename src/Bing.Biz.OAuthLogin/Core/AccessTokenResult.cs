﻿using Newtonsoft.Json;

namespace Bing.Biz.OAuthLogin.Core
{
    /// <summary>
    /// 访问令牌结果
    /// </summary>
    public class AccessTokenResult
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 有效期。单位：秒
        /// </summary>
        [JsonProperty("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
