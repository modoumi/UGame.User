/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2023/4/19 21:47:38                           */
/*==============================================================*/


drop view if exists v_sc_notify_user;

drop view if exists v_sc_notify_detail;

drop view if exists v_sc_marquee_user;

drop view if exists v_s_operator;

drop table if exists s_app;

drop table if exists s_app_lang;

drop table if exists s_channel;

drop table if exists s_country;

drop table if exists s_currency;

drop table if exists s_currency_change;

drop table if exists s_data_move;

drop table if exists s_data_move_log;

drop table if exists s_language;

drop table if exists s_log;

drop table if exists s_login_log;

drop table if exists s_mq_log;

drop table if exists s_operator;

drop table if exists s_operator_app;

drop table if exists s_operator_base;

drop table if exists s_provider;

drop table if exists s_provider_order;

drop table if exists s_provider_trans_log;

drop table if exists s_settings;

drop table if exists s_user;

drop table if exists s_user_day;

drop table if exists s_user_ex;

drop table if exists sc_app_currency_chips;

drop table if exists sc_banner;

drop table if exists sc_cash_audit;

drop table if exists sc_cash_audit_log;

drop table if exists sc_marquee;

drop table if exists sc_marquee_user;

drop table if exists sc_notify;

drop table if exists sc_notify_detail;

drop table if exists sc_notify_user;

drop table if exists sc_notify_user_log;

drop table if exists sc_user_app;

drop table if exists sm_sms;

drop table if exists sm_sms_order;

drop table if exists sm_template;

drop table if exists sm_template_lang;

drop table if exists sm_template_sms;

drop table if exists sp_hub88_currency;

drop table if exists sp_pgsoft_currency;

drop table if exists sr_app_user_rank;

drop table if exists sr_oper_bank_paytype_day;

drop table if exists sr_oper_day;

drop table if exists sr_user_day;

drop table if exists sr_user_settl_day;

drop table if exists src_push_config;

drop table if exists src_push_message;

drop table if exists src_withdrawal_config;

/*==============================================================*/
/* Table: s_app                                                 */
/*==============================================================*/
create table s_app
(
   AppID                varchar(50) not null  comment 'App编码',
   ProviderID           varchar(50)  comment '应用提供商编码',
   ProviderAppId        varchar(50)  comment '应用提供商的应用编码',
   AppName              varchar(50)  comment 'App名称',
   AppType              int not null default 0  comment 'App类型1-大厅2-游戏3-应用',
   ServerType           int not null default 0  comment 'app服务端类型0-未知1-api2-websocket',
   ServerUrl            text  comment '应用服务端线上URL（仅api game需要配置）',
   ServerUrlStaging     text  comment '应用服务端仿真URL',
   ServerUrlDebug       text  comment '应用服务端联调URL',
   Langs                text  comment 'App支持的语言。|分割',
   Note                 text  comment '备注信息',
   Status               int not null default 0  comment '状态(0-无效1-有效)',
   HasJackpot           bool not null default 0  comment '是否有Jackpot'
);

alter table s_app comment '应用列表';

alter table s_app
   add primary key (AppID);

/*==============================================================*/
/* Table: s_app_lang                                            */
/*==============================================================*/
create table s_app_lang
(
   AppID                varchar(50) not null  comment '应用编码',
   LangID               varchar(5) not null  comment '语言(空字符串表示默认)',
   IsSupport            bool not null  comment '是否支持',
   AppName              varchar(50)  comment '应用名称',
   AppDesc              text  comment '应用详细描述'
);

alter table s_app_lang comment 'app多语言定义';

alter table s_app_lang
   add primary key (AppID, LangID);

/*==============================================================*/
/* Table: s_channel                                             */
/*==============================================================*/
create table s_channel
(
   ChannelID            varchar(50) not null  comment '推广渠道编码',
   CName                varchar(100)  comment '渠道名称',
   CType                tinyint not null default 0  comment '渠道类型（0-公司1-个人）',
   BranchKey            varchar(250)  comment 'branch关键字',
   GAKey                varchar(250)  comment 'GA关键字',
   Note                 varchar(1000)  comment '备注信息',
   Status               int not null default 0  comment '状态(0-无效1-有效)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table s_channel comment '用户推广渠道（仅拉新用户，无产品定制需求）';

alter table s_channel
   add primary key (ChannelID);

/*==============================================================*/
/* Table: s_country                                             */
/*==============================================================*/
create table s_country
(
   CountryID            varchar(5) not null  comment '国家编码3位大写（ISO 3166-1）',
   CountryID2           varchar(5)  comment '国家编码2位大写（ISO 3166-1）',
   CountryCode          varchar(5)  comment '国家数字编码',
   CurrencyID           varchar(5)  comment '主货币类型',
   CallingCode          varchar(20)  comment '国际电话区号不带+号',
   Name                 varchar(20)  comment '国家名称',
   EnName               varchar(50)  comment '英文名称',
   TimeZone             int not null default 0  comment '默认国家时区',
   Status               int not null default 0  comment '状态0-初始1-启用'
);

alter table s_country comment '国家编码ISO 3166-1三位字母大写 USA';

alter table s_country
   add primary key (CountryID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create unique index Index_1 on s_country
(
   CountryID2
);

/*==============================================================*/
/* Index: Index_2                                               */
/*==============================================================*/
create unique index Index_2 on s_country
(
   CountryCode
);

/*==============================================================*/
/* Table: s_currency                                            */
/*==============================================================*/
create table s_currency
(
   CurrencyID           varchar(5) not null  comment '货币编码（ISO 4217大写3位）',
   CurrencyCode         varchar(5)  comment '货币数字编码（ISO 4217 3位）',
   BaseUnit             decimal(27,18) not null default 1  comment '基础货币单位（1单位货币等于多少最小币值）',
   Name                 varchar(50)  comment '货币名称',
   CurrencyType         int not null default 0  comment '类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH',
   Status               int not null default 0  comment '状态0-初始1-启用'
);

alter table s_currency comment '货币定义大写 ISO 4217';

alter table s_currency
   add primary key (CurrencyID);

/*==============================================================*/
/* Table: s_currency_change                                     */
/*==============================================================*/
create table s_currency_change
(
   ChangeID             varchar(38) not null  comment '货币变化编码(GUID)',
   ProviderID           varchar(50)  comment '应用提供商编码',
   AppID                varchar(50)  comment '应用编码',
   OperatorID           varchar(50)  comment '运营商编码',
   UserID               varchar(38)  comment '用户编码(GUID)',
   UserKind             int not null default 0  comment '用户类型
             0-未知
             1-普通用户
             2-开发用户
             3-线上测试用户（调用第三方扣减）
             4-线上测试用户（不调用第三方扣减）
             5-仿真用户
             6-接口联调用户
             9-管理员',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型（货币缩写USD）',
   SettlStatus          int not null default 0  comment '结算状态（0-未结算1-已结算）',
   Reason               varchar(255)  comment '变化原因',
   PlanAmount           bigint not null default 0  comment '计划变化金额（正负数）',
   Meta                 text  comment '扩展数据',
   SourceType           int not null default 0  comment '0-未知1-运营活动2',
   SourceTable          varchar(100)  comment '源表名',
   SourceId             varchar(50)  comment '源表编码',
   Status               int not null default 0  comment '状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间',
   DealTime             datetime  comment '处理时间',
   DealStatus           text  comment '处理状态数据',
   Amount               bigint not null default 0  comment '实际金额（正负数）',
   EndBalance           bigint not null default 0  comment '处理后余额',
   SettlTable           varchar(100)  comment '结算表名',
   SettlId              varchar(50)  comment '结算编码',
   SettlAmount          bigint not null default 0  comment '结算金额(正负数)',
   CurrencyType         int not null default 0  comment '货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH'
);

alter table s_currency_change comment '用户货币变化表（除s_provider_order,s_bank_order,s_operator_order以外的变化';

alter table s_currency_change
   add primary key (ChangeID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on s_currency_change
(
   DealTime,
   OperatorID,
   UserKind,
   Status
);

/*==============================================================*/
/* Table: s_data_move                                           */
/*==============================================================*/
create table s_data_move
(
   DataMoveID           int not null  comment '数据迁移编码',
   TableName            varchar(100) not null  comment '表名',
   DateFieldName        varchar(100)  comment '时间字段名',
   HandleMode           int not null default 0  comment '处理方式
             0-删除数据
             1-按年生成备份表：tablename_yyyy
             2-按季度生成备份表：tablename_yyyy1,2,3,4
             3-按月生成备份表：tablename_yyyyMM
             4-按日生成备份表：tablename_yyyyMMdd',
   KeepValue            int not null default 0  comment '保留数据长度（根据HandleMode值不同）
             0-删除数据 ==> 表示保留的天数
             1-按年生成备份表：tablename_yyyy => 表示保留的年数
             2-按季度生成备份表：tablename_yyyy1,2,3,4 ==> 表示保留的季节数
             3-按月生成备份表：tablename_yyyyMM ==> 表示保留的月份数
             4-按日生成备份表：tablename_yyyyMMdd ==> 表示保留的天数',
   WhereStatement       varchar(1000)  comment '迁移数据的条件',
   Status               int not null default 0  comment '状态(0-无效1-有效)'
);

alter table s_data_move comment '数据迁移策略定义，就解决大表数据清理';

alter table s_data_move
   add primary key (DataMoveID);

/*==============================================================*/
/* Table: s_data_move_log                                       */
/*==============================================================*/
create table s_data_move_log
(
   LogID                varchar(38) not null  comment '日志编码(GUID)',
   DataMoveID           int not null  comment '数据迁移编码',
   TableName            varchar(100) not null  comment '表名',
   BeginDate            date not null  comment '起始时间',
   EndDate              date not null  comment '结束时间',
   HandleMode           int not null default 0  comment '处理方式
             0-删除数据
             1-按年生成备份表：tablename_yyyy
             2-按季度生成备份表：tablename_yyyy1,2,3,4
             3-按月生成备份表：tablename_yyyyMM
             4-按日生成备份表：tablename_yyyyMMdd',
   KeepValue            int not null default 0  comment '保留数据长度（根据HandleMode值不同）HandleMode=
             0-删除数据 ==> 表示保留的天数
             1-按年生成备份表：tablename_yyyy =》 表示保留的年数
             2-按季度生成备份表：tablename_yyyy1,2,3,4 ==》 表示保留的季节数
             3-按月生成备份表：tablename_yyyyMM ==> 表示保留的月份数
             4-按日生成备份表：tablename_yyyyMMdd ==> 表示保留的天数',
   BackupTableName      varchar(100)  comment '备份表名',
   RowNum               int not null default 0  comment '处理记录数',
   Note                 varchar(255)  comment '描述',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table s_data_move_log comment '数据迁移日志';

alter table s_data_move_log
   add primary key (LogID);

/*==============================================================*/
/* Table: s_language                                            */
/*==============================================================*/
create table s_language
(
   LangID               varchar(5) not null  comment '语言代码2位小写（ISO 639-1 ）',
   LangID3              varchar(5) not null  comment '语言代码3位小写',
   Name                 varchar(50)  comment '中文名称',
   EnName               varchar(50)  comment '英文名称',
   LangName             varchar(50)  comment '对应语言的名称',
   Status               int not null default 0  comment '状态0-初始1-启用'
);

alter table s_language comment '系统语言定义（ISO 639-1 中的小写双字母）
zh-cn 简体中文和zh-tw繁体中文';

alter table s_language
   add primary key (LangID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create unique index Index_1 on s_language
(
   LangID3
);

/*==============================================================*/
/* Table: s_log                                                 */
/*==============================================================*/
create table s_log
(
   LogID                bigint not null auto_increment  comment '日志主键GUID',
   Timestamp            datetime not null  comment '日志发生时间',
   Level                varchar(15)  comment '日志等级(Verbose|Debug|Information|Warning|Error|Fatal)',
   LevelNum             tinyint not null default 0  comment '日志等级数字
             0-Verbose
             1-Debug
             2-Information
             3-Warning
             4-Error
             5-Fatal',
   Template             text  comment '消息模板',
   Message              text  comment '消息内容',
   Exception            text  comment '异常',
   Properties           text  comment '属性',
   ProjectID            varchar(100)  comment '程序标识',
   Environment          varchar(20)  comment '环境',
   MachineIP            varchar(20)  comment '服务器IP',
   TemplateHash         bigint  comment '消息模板hash'
);

alter table s_log comment '系统级日志表';

alter table s_log
   add primary key (LogID);

/*==============================================================*/
/* Index: index_1                                               */
/*==============================================================*/
create index index_1 on s_log
(
   Timestamp,
   LevelNum
);

/*==============================================================*/
/* Table: s_login_log                                           */
/*==============================================================*/
create table s_login_log
(
   LogID                varchar(38) not null  comment '日志编码(GUID)',
   UserID               varchar(38)  comment '用户编码',
   OperatorID           varchar(50)  comment '运营商编码',
   AppID                varchar(50)  comment '应用编码',
   LoginDate            datetime  comment '登录时间',
   LogoutDate           datetime  comment '退出时间',
   VersionID            varchar(100)  comment 'App版本号',
   LangID               varchar(20)  comment '语言',
   IsMobile             bool  comment '是否移动端',
   OS                   varchar(20)  comment '系统',
   Browser              varchar(20)  comment '浏览器',
   Status               int not null default 0  comment '状态(0-失败1-成功)',
   Message              text  comment '信息描述（错误原因）',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table s_login_log comment '原始用户登录日志
登录登出时都插入数据';

alter table s_login_log
   add primary key (LogID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on s_login_log
(
   UserID,
   RecDate
);

/*==============================================================*/
/* Table: s_mq_log                                              */
/*==============================================================*/
create table s_mq_log
(
   MQLogID              varchar(36) not null  comment 'MQ异常日志编码',
   MessageType          varchar(100)  comment '消息类型',
   MessageLevel         tinyint not null default 0  comment '消息级别（越大越重要）',
   ProjectId            varchar(100)  comment '项目名称',
   ActionName           varchar(100)  comment '响应Action',
   Exception            text  comment '异常消息',
   Status               int not null default 0  comment '消息状态（0-初始1-异常状态2-异常已处理3-异常无需处理）',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table s_mq_log comment 'mq执行异常日志';

alter table s_mq_log
   add primary key (MQLogID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on s_mq_log
(
   MessageType
);

/*==============================================================*/
/* Table: s_operator                                            */
/*==============================================================*/
create table s_operator
(
   OperatorID           varchar(50) not null  comment '运营商编码（小写，唯一）',
   OperatorBaseID       varchar(50) not null  comment '运营商基础编码（小写，唯一）',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   Langs                text  comment '平台支持的语言。|分割',
   CurrencyID           varchar(5)  comment '货币类型（货币缩写USD）',
   LobbyUrl             varchar(255)  comment '大厅客户端线上URL',
   LobbyUrlStaging      varchar(255)  comment '大厅客户端仿真URL',
   LobbyUrlDebug        varchar(255)  comment '大厅客户端调试URL',
   BankUrl              varchar(255)  comment '银行客户端线上URL',
   BankUrlStaging       varchar(255)  comment '银行客户端仿真URL',
   BankUrlDebug         varchar(255)  comment '银行客户端调试URL',
   BranchKey            varchar(250)  comment 'branch关键字',
   GAKey                varchar(250)  comment 'GA关键字',
   Status               int not null default 0  comment '状态(0-无效1-有效)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table s_operator comment '运营商';

alter table s_operator
   add primary key (OperatorID);

/*==============================================================*/
/* Table: s_operator_app                                        */
/*==============================================================*/
create table s_operator_app
(
   AppID                varchar(50) not null  comment '应用编码',
   OperatorID           varchar(50) not null  comment '运营商编码',
   OperatorAppId        varchar(100)  comment '对应的运营商应用编码',
   AppUrl               text  comment '应用客户端线上URL',
   AppUrlStaging        text  comment '应用客户端仿真URL',
   AppUrlDebug          text  comment '应用客户端联调URL',
   Status               int not null default 0  comment '状态0-无效1-在线2-维护中3-测试中',
   OperatorThumb        varchar(255)  comment '游戏预览图url',
   OperatorBg           varchar(255)  comment '游戏背景图url',
   OperatorRoundUrl     varchar(255)  comment '游戏回合url'
);

alter table s_operator_app comment '运营商应用授权（混服使用相同appid，独服使用自定义appid）';

alter table s_operator_app
   add primary key (AppID, OperatorID);

/*==============================================================*/
/* Table: s_operator_base                                       */
/*==============================================================*/
create table s_operator_base
(
   OperatorBaseID       varchar(50) not null  comment '运营商基础编码（小写，唯一）',
   OperatorName         varchar(100)  comment '运营商名称',
   OperatorType         int not null default 1  comment '运营商类型
             0-自有
             1-第三方有用户有充值
             2-第三方有用户无充值
             3-第三方无用户无充值',
   OperatorMode         int  comment '独服混服类型(0-混服1-独服)',
   AllowVisitor         bool not null default 0  comment '是否允许游客',
   OperPublicKey        text  comment '运营商公钥',
   OperPrivateKey       text  comment '运营商私钥（仅测试）',
   OwnPublicKey         text  comment '我方的公钥',
   OwnPrivateKey        text  comment '我方的私钥',
   Note                 text  comment '备注信息',
   SettlDayNum          int not null default 0  comment '结算日，如5表示每月结算包含5号',
   Status               int not null default 0  comment '状态(0-无效1-有效)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间',
   OperAdminUrl         varchar(255)  comment '运营商后台地址',
   OperAdminUser        varchar(50)  comment '运营商后台账号',
   OperAdminPwd         varchar(255)  comment '运营商后台密码',
   CashAudit            int not null default 0  comment '提现审计模式0-不审计1-审计'
);

alter table s_operator_base comment '供应商基础定义';

alter table s_operator_base
   add primary key (OperatorBaseID);

/*==============================================================*/
/* Table: s_provider                                            */
/*==============================================================*/
create table s_provider
(
   ProviderID           varchar(50) not null  comment '应用提供商编码（小写，唯一）自有own',
   ProviderName         varchar(100)  comment '应用提供商名称',
   ProviderType         int not null default 1  comment '应用提供商类型（0-自有 1-第三方）',
   ApiUrl               varchar(255)  comment '获取应用客户端URL的API路径（应用提供商提供）',
   ApiUrlStaging        varchar(255)  comment '获取应用客户端URL的API路径（仿真）',
   ApiUrlDebug          varchar(255)  comment '获取应用客户端URL的API路径（联调）',
   ProvPublicKey        text  comment '应用提供商公钥',
   ProvPrivateKey       text  comment '应用提供商私钥（仅测试）',
   OwnPublicKey         text  comment '我方的公钥',
   OwnPrivateKey        text  comment '我方的私钥',
   Mobile               varchar(50)  comment '手机号',
   Email                varchar(100)  comment '邮箱',
   Note                 text  comment '备注信息',
   SettlDayNum          int not null default 0  comment '结算日，如5表示每月结算包含5号',
   Status               int not null default 0  comment '状态(0-无效1-有效)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间',
   AdminUser            varchar(50)  comment '我方提供的后台账号',
   AdminPwd             varchar(255)  comment '我方提供的后台密码',
   ProvAdminUrl         varchar(255)  comment '应用提供商后台地址',
   ProvAdminUser        varchar(50)  comment '应用提供商后台账号',
   ProvAdminPwd         varchar(255)  comment '应用提供商后台密码'
);

alter table s_provider comment '应用提供商';

alter table s_provider
   add primary key (ProviderID);

/*==============================================================*/
/* Table: s_provider_order                                      */
/*==============================================================*/
create table s_provider_order
(
   OrderID              varchar(38) not null  comment '供应商请求生成的订单编码 GUID',
   ProviderID           varchar(50)  comment '应用提供商编码',
   AppID                varchar(50)  comment '应用编码',
   OperatorID           varchar(50)  comment '运营商编码',
   UserID               varchar(38)  comment '用户编码(GUID)',
   UserKind             int not null default 0  comment '用户类型
             0-未知
             1-普通用户
             2-开发用户
             3-线上测试用户（调用第三方扣减）
             4-线上测试用户（不调用第三方扣减）
             5-仿真用户
             6-接口联调用户
             9-管理员',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型（货币缩写RMB,USD）',
   CurrencyType         int not null default 0  comment '货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH',
   ReqMark              int not null default 0  comment '请求接口类型（0-balance1-Bet 2-Win 3-BetWin4-Rollback）',
   RequestUUID          varchar(38)  comment '请求唯一号',
   ProviderOrderId      varchar(50)  comment '应用提供商订单编码(TransactionUUID)',
   ReferProviderOrderId varchar(50)  comment '应用提供商原始订单编码(ReferenceTransactionUUID)',
   RoundClosed          bool not null default 1  comment '回合是否关闭',
   RoundId              varchar(50)  comment '回合标识',
   RewardUUID           varchar(50)  comment '我方提供的奖励id',
   IsFree               bool not null default 0  comment '是否促销产生的交易',
   PlanBet              bigint not null default 0  comment '计划下注数量（正数）',
   PlanWin              bigint not null default 0  comment '计划返奖数量（正数）',
   PlanAmount           bigint not null default 0  comment '计划账户变化数量（正负数）',
   Meta                 text  comment '扩展数据',
   Status               int not null default 0  comment '状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '订单时间',
   ResponseTime         datetime  comment '返回时间',
   ResponseStatus       varchar(255)  comment '返回状态',
   Amount               bigint not null default 0  comment '实际账户变化数量（正负数）',
   EndBalance           bigint not null default 0  comment '处理后余额',
   SettlTable           varchar(100)  comment '结算表名',
   SettlId              varchar(50)  comment '结算编码',
   SettlAmount          bigint not null default 0  comment '结算金额(正负数)',
   SettlStatus          int not null default 0  comment '结算状态（0-未结算1-已结算）'
);

alter table s_provider_order comment '应用提供商调用我方接口订单';

alter table s_provider_order
   add primary key (OrderID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on s_provider_order
(
   ProviderID,
   ProviderOrderId
);

/*==============================================================*/
/* Index: Index_2                                               */
/*==============================================================*/
create index Index_2 on s_provider_order
(
   ResponseTime,
   Status,
   UserKind
);

/*==============================================================*/
/* Table: s_provider_trans_log                                  */
/*==============================================================*/
create table s_provider_trans_log
(
   TransLogID           varchar(38) not null  comment '请求应答日志编码(GUID)',
   OrderID              varchar(38)  comment '供应商请求生成的订单编码 GUID',
   ProviderID           varchar(50)  comment '应用提供商编码',
   OperatorID           varchar(50)  comment '运营商编码',
   TransType            int not null default 0  comment '通讯类型(0-我方发起1-对方发起)',
   TransMark            varchar(255)  comment '通讯标记（接口标识）',
   RequestTime          datetime not null  comment '请求时间',
   RequestBody          text  comment '请求消息（我方请求或对方请求）json',
   Status               int not null default 0  comment '消息状态（0-初始1-返回成功2-返回失败）',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间',
   ResponseTime         datetime  comment '返回时间',
   ResponseBody         text  comment '响应消息（对方响应或我方响应）json',
   Exception            text  comment '异常消息'
);

alter table s_provider_trans_log comment '与应用提供商通讯日志';

alter table s_provider_trans_log
   add primary key (TransLogID);

/*==============================================================*/
/* Table: s_settings                                            */
/*==============================================================*/
create table s_settings
(
   SettingsKey          varchar(200) not null  comment '配置键（规则小写：ProjectID:XXX:XXX）',
   Environment          varchar(100) not null  comment '环境变量',
   SettingsValue        varchar(255)  comment '配置值'
);

alter table s_settings comment '应用程序配置表';

alter table s_settings
   add primary key (SettingsKey, Environment);

/*==============================================================*/
/* Table: s_user                                                */
/*==============================================================*/
create table s_user
(
   UserID               varchar(38) not null  comment '用户编码(GUID)',
   UserMode             int not null default 1  comment '用户登录模式 1-游客 2-注册用户',
   Nickname             varchar(50)  comment '昵称',
   FromMode             int not null default 0  comment '新用户来源方式
             0-获得运营商的新用户(s_operator)
             1-推广员获得的新用户（userid）uid=xxx
             2-推广渠道通过url获得的新用户（s_channel)  cid=xxx',
   FromId               varchar(100)  comment '对应的编码（根据FromMode变化）
             FromMode=
             0-运营商的新用户(s_operator)==> OperatorID
             1-推广员获得的新用户（userid） ==> 邀请人的UserID
             2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
             3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID',
   OperatorID           varchar(50)  comment '运营商编码',
   OperatorUserId       varchar(50)  comment '运营商用户标识（用户关联）
             我方运营商为null',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型',
   Cash                 bigint not null default 0  comment '现金（一级货币）*100000',
   Coin                 bigint not null default 0  comment '硬币（二级货币）',
   Gold                 bigint not null default 0  comment '金币',
   Point                bigint not null default 0  comment '积分',
   SWB                  bigint not null default 0  comment '试玩币',
   UserKind             int not null default 0  comment '用户类型
             0-未知
             1-普通用户
             2-开发用户
             3-线上测试用户（调用第三方扣减）
             4-线上测试用户（不调用第三方扣减）
             5-仿真用户
             6-接口联调用户
             9-管理员',
   IMEI                 varchar(20)  comment 'IMEI',
   GAID                 varchar(36)  comment 'GAID',
   Status               int not null default 0  comment '状态
             0-未知
             1-有效
             2-用户数据异常封闭
             9-系统封闭',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间',
   RegistDate           datetime  comment '注册时间',
   LastLoginDate        datetime not null default CURRENT_TIMESTAMP  comment '最后一次登录时间',
   Mobile               varchar(50)  comment '手机号',
   Email                varchar(100)  comment '邮箱',
   Username             varchar(50)  comment '登录用户名',
   Password             varchar(255)  comment '密码哈希值',
   PasswordSalt         varchar(40)  comment '密码哈希Salt',
   HasBet               bool not null default 0  comment '是否下过注',
   HasPay               bool not null default 0  comment '是否充过值',
   HasCash              bool not null default 0  comment '是否提过现'
);

alter table s_user comment '用户表';

alter table s_user
   add primary key (UserID);

/*==============================================================*/
/* Index: Index_4                                               */
/*==============================================================*/
create index Index_4 on s_user
(
   Username
);

/*==============================================================*/
/* Index: Index_3                                               */
/*==============================================================*/
create index Index_3 on s_user
(
   Email
);

/*==============================================================*/
/* Index: Index_2                                               */
/*==============================================================*/
create index Index_2 on s_user
(
   Mobile
);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on s_user
(
   OperatorID,
   OperatorUserId
);

/*==============================================================*/
/* Index: Index_5                                               */
/*==============================================================*/
create index Index_5 on s_user
(
   Nickname
);

/*==============================================================*/
/* Table: s_user_day                                            */
/*==============================================================*/
create table s_user_day
(
   DayID                date not null  comment '统计日',
   UserID               varchar(38) not null  comment '用户编码(GUID)',
   UserKind             int not null default 0  comment '用户类型
             0-未知
             1-普通用户
             2-开发用户
             3-线上测试用户（调用第三方扣减）
             4-线上测试用户（不调用第三方扣减）
             5-仿真用户
             6-接口联调用户
             9-管理员',
   OperatorID           varchar(50)  comment '运营商编码',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型（仅现金，其它另行统计）',
   IsNew                bool not null default 0  comment '是否新用户',
   IsRegister           bool not null default 0  comment '当天是否进行了注册',
   RegistDate           datetime  comment '注册时间',
   IsLogin              bool not null default 0  comment '当天是否登录',
   IsNewPay             bool not null default 0  comment '是否是第一次充值用户',
   IsNewBet             bool not null default 0  comment '是否是第一次下注用户',
   IsNewCash            bool not null default 0  comment '是否第一次体现用户',
   HasCash              bool not null default 0  comment '当天是否有提现行为',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table s_user_day comment '用户每天统计';

alter table s_user_day
   add primary key (DayID, UserID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on s_user_day
(
   DayID,
   UserKind,
   OperatorID
);

/*==============================================================*/
/* Table: s_user_ex                                             */
/*==============================================================*/
create table s_user_ex
(
   UserID               varchar(38) not null  comment '用户编码(GUID)',
   UserKind             int not null default 0  comment '用户类型
             0-未知
             1-普通用户
             2-开发用户
             3-线上测试用户（调用第三方扣减）
             4-线上测试用户（不调用第三方扣减）
             5-仿真用户
             6-接口联调用户
             9-管理员',
   OperatorID           varchar(50)  comment '运营商编码',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型（仅现金，其它另行统计）',
   TotalBetAmount       bigint not null default 0  comment '下注总额',
   TotalWinAmount       bigint not null default 0  comment '返奖总额',
   TotalPayAmount       bigint not null default 0  comment '充值总额',
   TotalCashAmount      bigint not null default 0  comment '提现总额'
);

alter table s_user_ex comment '用户实时数据';

alter table s_user_ex
   add primary key (UserID);

/*==============================================================*/
/* Table: sc_app_currency_chips                                 */
/*==============================================================*/
create table sc_app_currency_chips
(
   AppID                varchar(50) not null  comment '应用编码',
   CurrencyID           varchar(5) not null  comment '货币类型',
   Chips                decimal not null default 0  comment '筹码数量'
);

alter table sc_app_currency_chips comment 'app中使用的货币的筹码定义';

alter table sc_app_currency_chips
   add primary key (AppID, CurrencyID, Chips);

/*==============================================================*/
/* Table: sc_banner                                             */
/*==============================================================*/
create table sc_banner
(
   BannerID             varchar(38) not null  comment 'Banner编码GUID',
   AppID                varchar(50)  comment '应用编码',
   OperatorID           varchar(50)  comment '运营商编码（null意味着默认）',
   Position             int not null default 0  comment '使用位置（app客户端分别自定义）',
   LangID               varchar(20)  comment '语言代码（null意味着默认）',
   Title                varchar(500)  comment '标题',
   Tip                  varchar(500)  comment '提示信息',
   Content              varchar(1000)  comment '内容',
   ImageUrl             varchar(500)  comment '图片地址',
   LinkType             int not null default 0  comment '链接类型1-相对地址2-绝对地址3-游戏地址',
   LinkUrl              varchar(500)  comment '链接地址',
   LinkParams           text  comment '可能存在的链接参数格式(json)',
   OrderNum             int not null default 0  comment '排序（从小到大）',
   Status               int not null default 0  comment '状态(0-无效1-有效)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table sc_banner comment '广告位定义';

alter table sc_banner
   add primary key (BannerID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on sc_banner
(
   AppID,
   Position,
   Status,
   OrderNum
);

/*==============================================================*/
/* Table: sc_cash_audit                                         */
/*==============================================================*/
create table sc_cash_audit
(
   CashAuditID          varchar(36) not null  comment '主键guid',
   UserID               varchar(36) not null  comment '用户编码(GUID)',
   OperatorID           varchar(50)  comment '运营商编码',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型',
   Mobile               varchar(50) not null  comment '手机号',
   Amount               bigint not null default 0  comment '提款金额',
   BankCode             varchar(50)  comment '银行代码',
   BankName             varchar(100)  comment '银行名称',
   AccName              varchar(50)  comment '用户账户名称',
   AccNumber            varchar(50) not null  comment '用户账号（银行卡号等）',
   Channels             int not null default 0  comment '提款渠道0-银行卡',
   Status               int not null default 0  comment '提款审核状态0-处理中1-通过2-拒绝',
   ApplyTime            datetime not null default CURRENT_TIMESTAMP  comment '申请时间',
   AuditTime            datetime  comment '审批时间',
   OperatorUser         varchar(50)  comment '审批人'
);

alter table sc_cash_audit comment '提款审核';

alter table sc_cash_audit
   add primary key (CashAuditID);

/*==============================================================*/
/* Table: sc_cash_audit_log                                     */
/*==============================================================*/
create table sc_cash_audit_log
(
   AuditLogID           varchar(36) not null  comment 'GUID',
   CashAuditID          varchar(36)  comment '主键guid',
   Action               int not null default 0  comment '操作0-提交申请1-审批通过2-审批拒绝',
   OperatorId           varchar(36) not null  comment '操作人ID',
   OperatorName         varchar(50) not null  comment '操作人',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table sc_cash_audit_log
   add primary key (AuditLogID);

/*==============================================================*/
/* Table: sc_marquee                                            */
/*==============================================================*/
create table sc_marquee
(
   MarqueeID            varchar(38) not null  comment '跑马灯编码GUID',
   AppID                varchar(50)  comment '应用编码',
   OperatorID           varchar(50)  comment '运营商编码（null意味着默认）',
   Position             int not null default 0  comment '使用位置（app客户端分别自定义）',
   LangID               varchar(20)  comment '语言代码（null意味着默认）',
   UserScope            int not null default 0  comment '范围类型0-全部用户1-特定用户',
   OrderNum             int not null default 0  comment '排序（越小越靠前）',
   MessageType          int not null default 0  comment '消息类型1-系统通知2-用户中奖信息',
   MessageContent       text  comment '消息内容
             恭喜{nickname}在{appName}中赢得{win}',
   MessageParams        text  comment '消息参数（根据消息类型变化）
             MessageType=2: {nickname:''xxx'',appId:''lobby'',appName:''大厅'',win:1000}',
   BeginDate            datetime not null default '2000-01-01'  comment '起始日期（默认2016-01-01）',
   EndDate              datetime not null default '9999-12-31'  comment '截止日期（默认2099-01-01）',
   ProviderID           varchar(50)  comment '应用提供商编码',
   Status               int not null default 0  comment '状态(0-无效1-有效)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table sc_marquee comment '系统跑马灯（只保存系统固定消息，其他放入redis）';

alter table sc_marquee
   add primary key (MarqueeID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on sc_marquee
(
   AppID,
   LangID,
   Position,
   OrderNum
);

/*==============================================================*/
/* Table: sc_marquee_user                                       */
/*==============================================================*/
create table sc_marquee_user
(
   MarqueeID            varchar(38) not null  comment '跑马灯编码GUID',
   UserID               varchar(38) not null  comment '用户编码(GUID)'
);

alter table sc_marquee_user comment '跑马灯具体用户';

alter table sc_marquee_user
   add primary key (MarqueeID, UserID);

/*==============================================================*/
/* Table: sc_notify                                             */
/*==============================================================*/
create table sc_notify
(
   NotifyID             varchar(38) not null  comment '主键GUID',
   AppID                varchar(50)  comment '应用编码',
   OperatorID           varchar(50)  comment '运营商编码（null意味着全部）',
   ActionAt             int not null default 0  comment '何时显示1-登录前2-注册后第一次登录3登录后',
   ShowAt               int not null default 0  comment '显示页面FLAG值0-全部1-首页2-4-8',
   UserScope            int not null default 0  comment '用户范围0-全部用户1-指定具体用户',
   Position             int not null default 0  comment '显示位置1-顶部2-中部3-下部',
   ShowTimes            int not null default 0  comment '展示次数',
   ShowInterval         int not null default 0  comment '展示间隔（分钟）',
   CloseInterval        int not null default 0  comment '自动关闭间隔（秒）0-手动关闭',
   LinkKind             int not null default 0  comment '链接类型1-email 2-url',
   LinkUrl              varchar(500)  comment '链接地址',
   OrderNum             int not null default 0  comment '排序（从小到大）',
   BeginDate            datetime not null default '2000-01-01'  comment '起始日期（默认2016-01-01）',
   EndDate              datetime not null default '9999-12-31'  comment '截止日期（默认2099-01-01）',
   Status               int not null default 0  comment '状态(0-无效1-有效)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table sc_notify comment '通知';

alter table sc_notify
   add primary key (NotifyID);

/*==============================================================*/
/* Table: sc_notify_detail                                      */
/*==============================================================*/
create table sc_notify_detail
(
   NotifyID             varchar(38) not null  comment '主键GUID',
   LangID               varchar(20) not null  comment '语言代码',
   Title                varchar(255)  comment '标题',
   ImageUrl             varchar(500)  comment '图片地址',
   Content              text  comment '内容',
   Txt1                 varchar(500)  comment '文本1',
   Txt2                 varchar(500)  comment '文本1',
   Txt3                 varchar(500)  comment '文本1',
   Txt4                 varchar(500)  comment '文本1',
   Txt5                 varchar(500)  comment '文本1',
   Img1                 varchar(500)  comment '图片1',
   Img2                 varchar(500)  comment '图片1',
   Img3                 varchar(500)  comment '图片1',
   Img4                 varchar(500)  comment '图片1',
   Img5                 varchar(500)  comment '图片1'
);

alter table sc_notify_detail comment '通知明细';

alter table sc_notify_detail
   add primary key (NotifyID, LangID);

/*==============================================================*/
/* Table: sc_notify_user                                        */
/*==============================================================*/
create table sc_notify_user
(
   NotifyID             varchar(38) not null  comment '主键GUID',
   UserID               varchar(38) not null  comment '用户编码'
);

alter table sc_notify_user comment '通知具体用户';

alter table sc_notify_user
   add primary key (UserID, NotifyID);

/*==============================================================*/
/* Table: sc_notify_user_log                                    */
/*==============================================================*/
create table sc_notify_user_log
(
   NotifyID             varchar(38) not null  comment '主键GUID',
   UserID               varchar(38) not null  comment '用户编码(GUID)',
   ShowCount            int not null default 0  comment '显示次数',
   LastShowDate         datetime not null default CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP  comment '最后一次展示时间'
);

alter table sc_notify_user_log comment '通知用户日志';

alter table sc_notify_user_log
   add primary key (NotifyID, UserID);

/*==============================================================*/
/* Table: sc_user_app                                           */
/*==============================================================*/
create table sc_user_app
(
   UserID               varchar(38) not null  comment '用户编码',
   AppID                varchar(50) not null  comment '应用编码',
   GuideNum             int not null default 0  comment '用户引导显示内容',
   UserAppStatus        int not null default 0  comment '用户状态(0-未知1-正常2-异常）',
   LastLoginDate        datetime  comment '最后一次访问时间'
);

alter table sc_user_app comment '用户所在应用的数据';

alter table sc_user_app
   add primary key (UserID, AppID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on sc_user_app
(
   UserID,
   AppID,
   UserAppStatus
);

/*==============================================================*/
/* Table: sm_sms                                                */
/*==============================================================*/
create table sm_sms
(
   SmsID                varchar(50) not null  comment '短信商编码',
   Name                 varchar(50)  comment '名称',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table sm_sms comment '短信商';

alter table sm_sms
   add primary key (SmsID);

/*==============================================================*/
/* Table: sm_sms_order                                          */
/*==============================================================*/
create table sm_sms_order
(
   OrderID              varchar(38) not null  comment '订单ID GUID',
   SmsID                varchar(50)  comment '短信商编码',
   ProviderID           varchar(50)  comment '应用提供商编码',
   AppID                varchar(50)  comment '应用编码',
   OperatorID           varchar(50)  comment '运营商编码',
   UserID               varchar(38)  comment '用户编码(GUID)',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型',
   TemplateID           varchar(50) not null  comment '模板ID',
   Content              text  comment '内容',
   RequestTime          datetime not null  comment '请求时间',
   RequestBody          text  comment '请求消息（我方请求或对方请求）json',
   Status               int not null default 0  comment '状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间',
   SmsOrderId           varchar(50)  comment '短信商订单编码',
   ResponseTime         datetime  comment '返回时间',
   ResponseBody         text  comment '响应消息（对方响应或我方响应）json',
   Exception            text  comment '异常消息',
   SettlTable           varchar(100)  comment '结算表名',
   SettlId              varchar(50)  comment '结算编码',
   SettlStatus          int not null default 0  comment '结算状态（0-未结算1-已结算）'
);

alter table sm_sms_order comment 'sms订单';

alter table sm_sms_order
   add primary key (OrderID);

/*==============================================================*/
/* Table: sm_template                                           */
/*==============================================================*/
create table sm_template
(
   TemplateID           varchar(50) not null  comment '模板ID',
   Name                 varchar(50)  comment '名称',
   SelectMode           int not null default 0  comment '选取规则0-OrderNum'
);

alter table sm_template comment '短信模板';

alter table sm_template
   add primary key (TemplateID);

/*==============================================================*/
/* Table: sm_template_lang                                      */
/*==============================================================*/
create table sm_template_lang
(
   TempLangID           varchar(36) not null  comment '主键GUID',
   TemplateID           varchar(50) not null  comment '模板ID',
   LangID               varchar(20)  comment '语言',
   Content              text  comment '内容'
);

alter table sm_template_lang comment '短信运营商可发送的模板';

alter table sm_template_lang
   add primary key (TempLangID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on sm_template_lang
(
   TemplateID,
   LangID
);

/*==============================================================*/
/* Table: sm_template_sms                                       */
/*==============================================================*/
create table sm_template_sms
(
   SmsTemplateID        varchar(36) not null  comment '主键GUID',
   TemplateID           varchar(50)  comment '模板ID',
   OperatorID           varchar(50)  comment '运营商编码（小写，唯一）',
   SmsID                varchar(50)  comment '短信商编码',
   OrderNum             int not null default 0  comment '排序，从小到大'
);

alter table sm_template_sms comment '模板使用的供应商定义表';

alter table sm_template_sms
   add primary key (SmsTemplateID);

/*==============================================================*/
/* Table: sp_hub88_currency                                     */
/*==============================================================*/
create table sp_hub88_currency
(
   TrdCurrencyID        varchar(20) not null  comment '对方currencyId',
   CurrencyID           varchar(20)  comment '货币类型',
   Name                 varchar(50)  comment '货币名称'
);

alter table sp_hub88_currency comment 'hub88与我方所支持的货币编码对应关系列表';

alter table sp_hub88_currency
   add primary key (TrdCurrencyID);

/*==============================================================*/
/* Table: sp_pgsoft_currency                                    */
/*==============================================================*/
create table sp_pgsoft_currency
(
   TrdCurrencyID        varchar(20) not null  comment '对方currencyId',
   CurrencyID           varchar(20) not null  comment '货币类型',
   Name                 varchar(50)  comment '货币名称',
   BaseUnit             int  comment '基础单位'
);

alter table sp_pgsoft_currency comment '提供商货币基础单位';

alter table sp_pgsoft_currency
   add primary key (TrdCurrencyID);

/*==============================================================*/
/* Table: sr_app_user_rank                                      */
/*==============================================================*/
create table sr_app_user_rank
(
   AppID                varchar(50)  comment '应用编码',
   UserID               varchar(38) not null  comment '用户编码(GUID)',
   Mobile               varchar(50)  comment '手机号',
   BetAmount            int not null default 0  comment '下注数额',
   WinAmount            int not null default 0  comment '赢数额'
);

alter table sr_app_user_rank comment 'app用户输赢排行(500人)';

/*==============================================================*/
/* Table: sr_oper_bank_paytype_day                              */
/*==============================================================*/
create table sr_oper_bank_paytype_day
(
   DayID                date not null  comment '统计日',
   OperatorID           varchar(50) not null  comment '运营商编码',
   BankID               varchar(50) not null  comment '银行编码',
   PaytypeID            int not null default 0  comment '支付方式0-综合1-visa2-spei',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型',
   PayUsers             int not null default 0  comment '充值用户数',
   CashUsers            int not null default 0  comment '提现用户数',
   PayOwnFee            decimal(20,2) not null default 0  comment '充值我方手续费',
   PayUserFee           decimal(20,2) not null default 0  comment '充值用户手续费',
   CashOwnFee           decimal(20,2) not null default 0  comment '提现我方手续费',
   CashUserFee          decimal(20,2) not null default 0  comment '提现用户手续费',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table sr_oper_bank_paytype_day comment '银行支付方式每日统计';

alter table sr_oper_bank_paytype_day
   add primary key (DayID, OperatorID, BankID, PaytypeID);

/*==============================================================*/
/* Index: Index_1                                               */
/*==============================================================*/
create index Index_1 on sr_oper_bank_paytype_day
(
   DayID,
   OperatorID
);

/*==============================================================*/
/* Table: sr_oper_day                                           */
/*==============================================================*/
create table sr_oper_day
(
   DayID                date not null  comment '统计日',
   OperatorID           varchar(50) not null  comment '运营商编码',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5) not null  comment '货币类型（仅现金，其它另行统计）',
   NewUsers             int not null default 0  comment '新增用户数DNU',
   LoginUsers           int not null default 0  comment '登录用户DAU',
   RegUsers             int not null default 0  comment '注册用户数',
   BetUsers             int not null default 0  comment '下注用户数',
   NewBetUsers          int not null default 0  comment '新下注用户数',
   NewUserBetAmount     bigint not null default 0  comment '新用户下注额',
   BetAmount            bigint not null default 0  comment '下注数量',
   WinAmount            bigint not null default 0  comment '返奖数量',
   PayUsers             int not null default 0  comment '下注用户数',
   NewPayUsers          int not null default 0  comment '新下注用户数',
   PayNotBetUsers       int not null default 0  comment '充值未下注用户数量',
   PayOwnFee            decimal(20,2) not null default 0  comment '充值我方手续费',
   PayUserFee           decimal(20,2) not null default 0  comment '充值用户手续费',
   NewUserPayAmount     bigint not null default 0  comment '新用户充值额',
   PayAmount            bigint not null default 0  comment '充值数量',
   CashUsers            int not null default 0  comment '提现用户数',
   NewCashUsers         int not null default 0  comment '新提现用户数',
   CashOwnFee           decimal(20,2) not null default 0  comment '提现我方手续费',
   CashUserFee          decimal(20,2) not null default 0  comment '提现用户手续费',
   NewUserCashAmount    bigint not null default 0  comment '新用户提现额',
   CashAmount           bigint not null default 0  comment '提现数量',
   ProfitAmount         bigint not null default 0  comment '盈利数量GGR（下注-返奖-活动）',
   PromotionFeeAmount   bigint not null default 0  comment '活动成本sum（s_currency_change.Amount）',
   NewARUP              float not null default 0  comment '新用户ARUP（新下注用户数/新用户下注-返奖总额）',
   ARUP                 float not null default 0  comment 'ARUP',
   RetentionD1          float not null default 0  comment '1日留存率',
   RetentionD3          float not null default 0  comment '1日留存率',
   RetentionD7          float not null default 0  comment '1日留存率',
   RetentionD15         float not null default 0  comment '1日留存率',
   RetentionD30         float not null default 0  comment '1日留存率',
   RegRetentionD1       float not null default 0  comment '注册1日留存率',
   RegRetentionD3       float not null default 0  comment '1日留存率',
   RegRetentionD7       float not null default 0  comment '1日留存率',
   RegRetentionD15      float not null default 0  comment '1日留存率',
   RegRetentionD30      float not null default 0  comment '1日留存率',
   Lose10               int not null default 0  comment '输10',
   Lose10_100           int not null default 0  comment '输10-100人数',
   Lose100_500          int not null default 0  comment '输10-100人数',
   Lose500_1000         int not null default 0  comment '输10-100人数',
   Lose1000_3000        int not null default 0  comment '输10-100人数',
   Lose3000_5000        int not null default 0  comment '输10-100人数',
   Lose5000_10000       int not null default 0  comment '输10-100人数',
   Lose10000_50000      int not null default 0  comment '输10-100人数',
   Lose50000            int not null default 0  comment '输10-100人数',
   Win10                int not null default 0  comment '输10',
   Win10_100            int not null default 0  comment '输10-100人数',
   Win100_500           int not null default 0  comment '输10-100人数',
   Win500_1000          int not null default 0  comment '输10-100人数',
   Win1000_3000         int not null default 0  comment '输10-100人数',
   Win3000_5000         int not null default 0  comment '输10-100人数',
   Win5000_10000        int not null default 0  comment '输10-100人数',
   Win10000_50000       int not null default 0  comment '输10-100人数',
   Win50000             int not null default 0  comment '输10-100人数',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table sr_oper_day comment '每日统计数据（每天统计）';

alter table sr_oper_day
   add primary key (DayID, OperatorID);

/*==============================================================*/
/* Table: sr_user_day                                           */
/*==============================================================*/
create table sr_user_day
(
   DayID                date not null  comment '统计日',
   UserID               varchar(38) not null  comment '用户编码(GUID)',
   OperatorID           varchar(50)  comment '运营商编码',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型（仅现金，其它另行统计）',
   BetAmount            bigint not null default 0  comment '当天用户下注额',
   WinAmount            bigint not null default 0  comment '当天用户返奖额',
   PayAmount            bigint not null default 0  comment '当天用户充值额',
   CashAmount           bigint not null default 0  comment '当天用户提现额',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table sr_user_day
   add primary key (DayID, UserID);

/*==============================================================*/
/* Table: sr_user_settl_day                                     */
/*==============================================================*/
create table sr_user_settl_day
(
   UserID               varchar(38) not null  comment '用户编码(GUID)',
   CurrencyID           varchar(20) not null  comment '货币类型',
   SumDay               date not null  comment '统计日',
   BatchID              varchar(38)  comment '批次ID',
   BetSum               bigint not null default 0  comment '下注金额',
   WinSum               bigint not null default 0  comment '返奖金额',
   AmountSum            bigint not null default 0  comment '收益金额（正负数）=返奖-下注',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table sr_user_settl_day comment '用户每日结算数据';

alter table sr_user_settl_day
   add primary key (SumDay, CurrencyID, UserID);

/*==============================================================*/
/* Table: src_push_config                                       */
/*==============================================================*/
create table src_push_config
(
   CfgID                varchar(36) not null  comment '键Key',
   OperatorID           varchar(50) not null  comment '运营商编码',
   CountryId            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型',
   GameTop              int  comment '游戏净盈利/净亏损limit',
   UserTop              int  comment '用户净盈利/净亏损limit',
   ResetTime            datetime not null  comment '数据重置时间',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table src_push_config comment '风控配置表';

alter table src_push_config
   add primary key (CfgID);

/*==============================================================*/
/* Table: src_push_message                                      */
/*==============================================================*/
create table src_push_message
(
   MessageID            varchar(36) not null  comment '主键GUID',
   SummaryTime          datetime not null  comment '汇总时间',
   OperatorID           varchar(50) not null  comment '运营商编码',
   SummaryType          int not null default 0  comment '统计类型
             1、平台每20分钟净输赢
             2、app每20分钟净盈利top
             3、app每20分钟净亏损top
             4、每20分钟用户净盈利top
             5、每20分钟用户净亏损top
             6、每20分钟用户充值总额
             7、每20分钟用户提现总额
             8、平台每小时注册用户数量
             9、平台每小时用户下注数量',
   CountryId            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(20)  comment '货币类型',
   AppID                varchar(50)  comment '应用编码',
   UserID               varchar(36)  comment '用户编码(GUID)',
   ProfitAmount         bigint not null default 0  comment '净盈利',
   LossAmount           bigint not null default 0  comment '净亏损',
   SumProfit            bigint not null default 0  comment '总净盈利',
   SumLoss              bigint not null default 0  comment '总净亏损',
   RegisterUsers        int not null default 0  comment '每小时注册数量',
   BetUsers             bigint not null default 0  comment '每小时下注用户数量',
   OrderNum             int not null default 0  comment '排序，从小到大',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '记录时间'
);

alter table src_push_message comment '推送消息表';

alter table src_push_message
   add primary key (MessageID);

/*==============================================================*/
/* Table: src_withdrawal_config                                 */
/*==============================================================*/
create table src_withdrawal_config
(
   ConfigID             varchar(36) not null  comment '主键guid',
   OperatorID           varchar(50) not null  comment '运营商编码',
   CountryID            varchar(5)  comment '国家编码ISO 3166-1三位字母 ',
   CurrencyID           varchar(5)  comment '货币类型',
   IsAudit              int not null default 1  comment '是否启用提现审批',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '创建时间',
   ApplyTime            datetime not null default CURRENT_TIMESTAMP  comment '申请时间',
   AuditTime            datetime  comment '审批时间',
   OperatorUser         varchar(50)  comment '审批人'
);

alter table src_withdrawal_config comment '提款配置表';

alter table src_withdrawal_config
   add primary key (ConfigID);

/*==============================================================*/
/* View: v_s_operator                                           */
/*==============================================================*/
create VIEW  v_s_operator
 as
select a1.OperatorID,a1.OperatorBaseID,a2.OperatorName,a2.OperatorType,a2.OperatorMode,a2.AllowVisitor,a2.OperPublicKey,a2.OwnPublicKey,a2.OwnPrivateKey,a2.SettlDayNum
	, a1.CountryID,a1.Langs,a1.CurrencyID,a1.LobbyUrl,a1.LobbyUrlStaging,a1.LobbyUrlDebug,a1.BankUrl,a1.BankUrlStaging,BankUrlDebug, a2.CashAudit
	, a1.`Status`&a2.`Status` as `Status`
from s_operator a1
	inner join s_operator_base a2 on a1.OperatorBaseID=a2.OperatorBaseID;

/*==============================================================*/
/* View: v_sc_marquee_user                                      */
/*==============================================================*/
create VIEW  v_sc_marquee_user
 as
select a1.* from sc_marquee_user a1 inner join sc_marquee a2 on a1.MarqueeID=a2.MarqueeID
where a2.Status=1 and now() BETWEEN a2.BeginDate and a2.EndDate;

/*==============================================================*/
/* View: v_sc_notify_detail                                     */
/*==============================================================*/
create VIEW  v_sc_notify_detail
 as
select
   a1.*,
   a2.AppID,
   a2.ActionAt,
   a2.ShowAt,
   a2.OperatorID,
   a2.UserScope,
   a2.Position,
   a2.ShowTimes,
   a2.ShowInterval,
   a2.CloseInterval,
   a2.LinkKind,
   a2.LinkUrl,
   a2.OrderNum
from
   sc_notify_detail a1
   inner join sc_notify a2 on  a1.NotifyID = a2.NotifyID
where
   a2.Status = 1
   and now() BETWEEN a2.BeginDate
   AND a2.EndDate;

/*==============================================================*/
/* View: v_sc_notify_user                                       */
/*==============================================================*/
create VIEW  v_sc_notify_user
 as
select a1.* from sc_notify_user a1 inner join sc_notify a2 on a1.NotifyID=a2.NotifyID
where a2.Status=1 and now() BETWEEN a2.BeginDate and a2.EndDate;

