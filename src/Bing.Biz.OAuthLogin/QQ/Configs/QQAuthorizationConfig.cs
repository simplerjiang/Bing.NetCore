﻿using System.ComponentModel.DataAnnotations;
using Bing.Biz.OAuthLogin.Core;

namespace Bing.Biz.OAuthLogin.QQ.Configs
{
    /// <summary>
    /// QQ 授权配置
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class QQAuthorizationConfig: AuthorizationConfigBase
    {
        /// <summary>
        /// 应用标识
        /// </summary>
        [Required(ErrorMessage = "应用标识[AppId]不能为空")]
        public string AppId { get; set; }

        /// <summary>
        /// 应用密钥
        /// </summary>
        [Required(ErrorMessage = "应用密钥[AppKey]不能为空")]
        public string AppKey { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [Required(ErrorMessage = "回调地址[CallbackUrl]不能为空")]
        public string CallbackUrl { get; set; }
    }
}
