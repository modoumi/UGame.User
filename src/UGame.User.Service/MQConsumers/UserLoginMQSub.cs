using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.BIZ.RabbitMQ;
using AiUo.Extensions.RabbitMQ;
using AiUo.Text;
using UGame.User.Service.Common;
using UGame.User.Service.Account;
using UGame.User.Common; 
using UGame.User.MQ.Xxyy;
using UGame.User.Repository;

namespace UGame.User.Service.MQConsumers
{
    public class UserLoginMQSub : MQBizSubConsumer<UserLoginMsg>
    {
        private UserDaySummaryService userDaySvc = new();
        private S_login_logMO _loginLogMo = new();
        public UserLoginMQSub()
        {
            AddHandler(AddSLoginLog);
            AddHandler(UpdateSUserDay);
        }

        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        protected override void Configuration(ISubscriptionConfiguration config)
        {
            
        }

        protected override Task OnMessage(UserLoginMsg message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async Task AddSLoginLog(UserLoginMsg message, CancellationToken cancellationToken)
        {
            var eo = new S_login_logEO
            {
                LogID = ObjectId.NewId(),
                UserID = message.UserId,
                OperatorID = message.OperatorId,
                AppID = message.AppId,
                LoginDate = DateTime.UtcNow,
                VersionID = message.VersionId,
                LangID = message.Language,
                IsMobile = message.IsMobile,
                OS = message.OS.ToString(),
                Browser = message.Browser.ToString(),
                UserIp = message.UserIp,
                Status = 1
            };
            await _loginLogMo.AddAsync(eo);
        }
        private async Task UpdateSUserDay(UserLoginMsg message, CancellationToken cancellationToken)
        {
            // s_user_day => IsLogin
            if (message.RegLoginType == RegLoginType.VisitorLogin
                || message.RegLoginType == RegLoginType.AccountLogin
                || message.RegLoginType == RegLoginType.JwtLogin)
            {
                await userDaySvc.SetIsLogin(new S_user_dayEO
                {
                    DayID = message.LoginDate.ToLocalTime(message.OperatorId),
                    UserID = message.UserId,
                    UserKind = message.UserKind,
                    OperatorID = message.OperatorId,
                    CountryID = message.CountryId,
                    CurrencyID = message.CurrencyId,
                    FromId = message.FromId,
                    FromMode = message.FromMode
                }, message.LoginDays, message.LastLoginTime);
            }
        }
    }
}
