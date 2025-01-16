﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Bank
{
    /// <summary>
    /// 用户提现消息
    /// </summary>
    public class UserCashMsg
    {
        public object MQMeta { get; set; }

        public string UserId { get; set; }
        public string AppId { get; set; }
        public int UserKind { get; set; }
        public DateTime CashTime { get; set; }
        public int PayType { get; set; }
        public int PaytypeChannel { get; set; }
        public long CashAmount { get; set; }
        public decimal UserFee { get; set; }
        public decimal OwnFee { get; set; }
        public string OperatorId { get; set; }
        public string CountryId { get; set; }
        public string CurrencyId { get; set; }
        /// <summary>
        /// 当天首提
        /// </summary>
        public bool FirstCashOfDay { get; set; }
        public object Meta { get; set; }

        /// <summary>
        /// 提现的订单号(sb_bank_order表）
        /// </summary>
        public string OrderID { get; set; }

        /// <summary>
        /// lobby订单id(目前是sc_cash_audit中主键id-cashauditid)
        /// </summary>
        public string AppOrderId { get; set; }

        /// <summary>
        /// 是否首次提现
        /// </summary>
        public bool IsFirst { get; set; }

        /// <summary>
        /// 提现状态0-成功 1-失败
        /// </summary>
        public int Status { get; set; }
    }
}
