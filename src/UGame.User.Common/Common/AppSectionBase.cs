using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Configuration;
using AiUo.Text;
using UGame.User.Common.Caching;

namespace UGame.User.Common
{
    public class AppSectionBase : ConfigSection
    {
        public override string SectionName => "AppOptions";

        #region 环境变量可配置
        private const string ENV_ServerId = "ENV_ServerId";
        private const string ENV_ServerType = "ENV_ServerType";
        private const string ENV_AppId = "ENV_AppId";
        private const string ENV_ServerUrl = "ENV_ServerUrl";

        /// <summary>
        /// 服务编码。
        /// 优先级：环境变量ENV_ServerId > 配置文件 > StringUtil.GetGuidString()
        /// </summary>
        public string ServerId { get; set; }
        /// <summary>
        /// 服务类型
        /// 优先级：环境变量ENV_ServerType > 配置文件
        /// </summary>
        public ServerType ServerType { get; set; } = ServerType.Normal;
        /// <summary>
        /// 优先级：环境变量ENV_AppId > 配置文件
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 提供给客户端的app服务地址：wss://host:port。
        /// lobby和游戏服务: 
        ///     服务启动时放入缓存 key: appId|serverType
        ///     优先级：环境变量ENV_ServerUrl > 配置文件(仅测试环境配置) > s_app.ServerUrl
        /// </summary>
        public string ServerUrl { get; set; }
        /// <summary>
        /// 是否websocket服务
        /// </summary>
        public virtual bool IsWSService { get; }

        /// <summary>
        /// IHost.StopAsync()的timeout秒时间(ExecuteAsync的stoppingToken.Cancel)
        /// </summary>
        public int ShutdownTimeout { get; set; } = 300;
        /// <summary>
        /// 是否启用 VerifyClientRequestAttribute
        /// </summary>
        public bool UseVerifyClientRequest { get; set; }
        #endregion

        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);
            
            // ServerId
            var serverId = Environment.GetEnvironmentVariable(ENV_ServerId);
            if (!string.IsNullOrEmpty(serverId))
            {
                ServerId = serverId;
            }
            else
            {
                if (string.IsNullOrEmpty(ServerId))
                    ServerId = ObjectId.NewId();
            }
            
            // ServerType
            var serverType = Environment.GetEnvironmentVariable(ENV_ServerType);
            if (!string.IsNullOrEmpty(serverType))
                ServerType = serverType.ToEnum<ServerType>();

            // AppId
            var appId = Environment.GetEnvironmentVariable(ENV_AppId);
            if (!string.IsNullOrEmpty(appId))
                AppId = appId;

            // ServerUrl 优先级：环境变量ENV_ServerUrl > 配置文件 > s_app.ServerUrl
            var serverUrl = Environment.GetEnvironmentVariable(ENV_ServerUrl);
            if (!string.IsNullOrEmpty(serverUrl))
                ServerUrl = serverUrl; //ENV_ServerUrl
        }
    }
}
