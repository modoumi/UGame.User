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
   AppID                varchar(50) not null  comment 'App����',
   ProviderID           varchar(50)  comment 'Ӧ���ṩ�̱���',
   ProviderAppId        varchar(50)  comment 'Ӧ���ṩ�̵�Ӧ�ñ���',
   AppName              varchar(50)  comment 'App����',
   AppType              int not null default 0  comment 'App����1-����2-��Ϸ3-Ӧ��',
   ServerType           int not null default 0  comment 'app���������0-δ֪1-api2-websocket',
   ServerUrl            text  comment 'Ӧ�÷��������URL����api game��Ҫ���ã�',
   ServerUrlStaging     text  comment 'Ӧ�÷���˷���URL',
   ServerUrlDebug       text  comment 'Ӧ�÷��������URL',
   Langs                text  comment 'App֧�ֵ����ԡ�|�ָ�',
   Note                 text  comment '��ע��Ϣ',
   Status               int not null default 0  comment '״̬(0-��Ч1-��Ч)',
   HasJackpot           bool not null default 0  comment '�Ƿ���Jackpot'
);

alter table s_app comment 'Ӧ���б�';

alter table s_app
   add primary key (AppID);

/*==============================================================*/
/* Table: s_app_lang                                            */
/*==============================================================*/
create table s_app_lang
(
   AppID                varchar(50) not null  comment 'Ӧ�ñ���',
   LangID               varchar(5) not null  comment '����(���ַ�����ʾĬ��)',
   IsSupport            bool not null  comment '�Ƿ�֧��',
   AppName              varchar(50)  comment 'Ӧ������',
   AppDesc              text  comment 'Ӧ����ϸ����'
);

alter table s_app_lang comment 'app�����Զ���';

alter table s_app_lang
   add primary key (AppID, LangID);

/*==============================================================*/
/* Table: s_channel                                             */
/*==============================================================*/
create table s_channel
(
   ChannelID            varchar(50) not null  comment '�ƹ���������',
   CName                varchar(100)  comment '��������',
   CType                tinyint not null default 0  comment '�������ͣ�0-��˾1-���ˣ�',
   BranchKey            varchar(250)  comment 'branch�ؼ���',
   GAKey                varchar(250)  comment 'GA�ؼ���',
   Note                 varchar(1000)  comment '��ע��Ϣ',
   Status               int not null default 0  comment '״̬(0-��Ч1-��Ч)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table s_channel comment '�û��ƹ��������������û����޲�Ʒ��������';

alter table s_channel
   add primary key (ChannelID);

/*==============================================================*/
/* Table: s_country                                             */
/*==============================================================*/
create table s_country
(
   CountryID            varchar(5) not null  comment '���ұ���3λ��д��ISO 3166-1��',
   CountryID2           varchar(5)  comment '���ұ���2λ��д��ISO 3166-1��',
   CountryCode          varchar(5)  comment '�������ֱ���',
   CurrencyID           varchar(5)  comment '����������',
   CallingCode          varchar(20)  comment '���ʵ绰���Ų���+��',
   Name                 varchar(20)  comment '��������',
   EnName               varchar(50)  comment 'Ӣ������',
   TimeZone             int not null default 0  comment 'Ĭ�Ϲ���ʱ��',
   Status               int not null default 0  comment '״̬0-��ʼ1-����'
);

alter table s_country comment '���ұ���ISO 3166-1��λ��ĸ��д USA';

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
   CurrencyID           varchar(5) not null  comment '���ұ��루ISO 4217��д3λ��',
   CurrencyCode         varchar(5)  comment '�������ֱ��루ISO 4217 3λ��',
   BaseUnit             decimal(27,18) not null default 1  comment '�������ҵ�λ��1��λ���ҵ��ڶ�����С��ֵ��',
   Name                 varchar(50)  comment '��������',
   CurrencyType         int not null default 0  comment '���� 1-COIN 2--GOLD 3-POINT 4-SWB 8-������� 9-CASH',
   Status               int not null default 0  comment '״̬0-��ʼ1-����'
);

alter table s_currency comment '���Ҷ����д ISO 4217';

alter table s_currency
   add primary key (CurrencyID);

/*==============================================================*/
/* Table: s_currency_change                                     */
/*==============================================================*/
create table s_currency_change
(
   ChangeID             varchar(38) not null  comment '���ұ仯����(GUID)',
   ProviderID           varchar(50)  comment 'Ӧ���ṩ�̱���',
   AppID                varchar(50)  comment 'Ӧ�ñ���',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   UserID               varchar(38)  comment '�û�����(GUID)',
   UserKind             int not null default 0  comment '�û�����
             0-δ֪
             1-��ͨ�û�
             2-�����û�
             3-���ϲ����û������õ������ۼ���
             4-���ϲ����û��������õ������ۼ���
             5-�����û�
             6-�ӿ������û�
             9-����Ա',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '�������ͣ�������дUSD��',
   SettlStatus          int not null default 0  comment '����״̬��0-δ����1-�ѽ��㣩',
   Reason               varchar(255)  comment '�仯ԭ��',
   PlanAmount           bigint not null default 0  comment '�ƻ��仯����������',
   Meta                 text  comment '��չ����',
   SourceType           int not null default 0  comment '0-δ֪1-��Ӫ�2',
   SourceTable          varchar(100)  comment 'Դ����',
   SourceId             varchar(50)  comment 'Դ�����',
   Status               int not null default 0  comment '״̬0-��ʼ1-������2-�ɹ�3-ʧ��4-�ѻع�5-�쳣���账��6-�쳣�Ѵ���',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��',
   DealTime             datetime  comment '����ʱ��',
   DealStatus           text  comment '����״̬����',
   Amount               bigint not null default 0  comment 'ʵ�ʽ���������',
   EndBalance           bigint not null default 0  comment '��������',
   SettlTable           varchar(100)  comment '�������',
   SettlId              varchar(50)  comment '�������',
   SettlAmount          bigint not null default 0  comment '������(������)',
   CurrencyType         int not null default 0  comment '�������� 1-COIN 2--GOLD 3-POINT 4-SWB 8-������� 9-CASH'
);

alter table s_currency_change comment '�û����ұ仯����s_provider_order,s_bank_order,s_operator_order����ı仯';

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
   DataMoveID           int not null  comment '����Ǩ�Ʊ���',
   TableName            varchar(100) not null  comment '����',
   DateFieldName        varchar(100)  comment 'ʱ���ֶ���',
   HandleMode           int not null default 0  comment '����ʽ
             0-ɾ������
             1-�������ɱ��ݱ�tablename_yyyy
             2-���������ɱ��ݱ�tablename_yyyy1,2,3,4
             3-�������ɱ��ݱ�tablename_yyyyMM
             4-�������ɱ��ݱ�tablename_yyyyMMdd',
   KeepValue            int not null default 0  comment '�������ݳ��ȣ�����HandleModeֵ��ͬ��
             0-ɾ������ ==> ��ʾ����������
             1-�������ɱ��ݱ�tablename_yyyy => ��ʾ����������
             2-���������ɱ��ݱ�tablename_yyyy1,2,3,4 ==> ��ʾ�����ļ�����
             3-�������ɱ��ݱ�tablename_yyyyMM ==> ��ʾ�������·���
             4-�������ɱ��ݱ�tablename_yyyyMMdd ==> ��ʾ����������',
   WhereStatement       varchar(1000)  comment 'Ǩ�����ݵ�����',
   Status               int not null default 0  comment '״̬(0-��Ч1-��Ч)'
);

alter table s_data_move comment '����Ǩ�Ʋ��Զ��壬�ͽ�������������';

alter table s_data_move
   add primary key (DataMoveID);

/*==============================================================*/
/* Table: s_data_move_log                                       */
/*==============================================================*/
create table s_data_move_log
(
   LogID                varchar(38) not null  comment '��־����(GUID)',
   DataMoveID           int not null  comment '����Ǩ�Ʊ���',
   TableName            varchar(100) not null  comment '����',
   BeginDate            date not null  comment '��ʼʱ��',
   EndDate              date not null  comment '����ʱ��',
   HandleMode           int not null default 0  comment '����ʽ
             0-ɾ������
             1-�������ɱ��ݱ�tablename_yyyy
             2-���������ɱ��ݱ�tablename_yyyy1,2,3,4
             3-�������ɱ��ݱ�tablename_yyyyMM
             4-�������ɱ��ݱ�tablename_yyyyMMdd',
   KeepValue            int not null default 0  comment '�������ݳ��ȣ�����HandleModeֵ��ͬ��HandleMode=
             0-ɾ������ ==> ��ʾ����������
             1-�������ɱ��ݱ�tablename_yyyy =�� ��ʾ����������
             2-���������ɱ��ݱ�tablename_yyyy1,2,3,4 ==�� ��ʾ�����ļ�����
             3-�������ɱ��ݱ�tablename_yyyyMM ==> ��ʾ�������·���
             4-�������ɱ��ݱ�tablename_yyyyMMdd ==> ��ʾ����������',
   BackupTableName      varchar(100)  comment '���ݱ���',
   RowNum               int not null default 0  comment '�����¼��',
   Note                 varchar(255)  comment '����',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table s_data_move_log comment '����Ǩ����־';

alter table s_data_move_log
   add primary key (LogID);

/*==============================================================*/
/* Table: s_language                                            */
/*==============================================================*/
create table s_language
(
   LangID               varchar(5) not null  comment '���Դ���2λСд��ISO 639-1 ��',
   LangID3              varchar(5) not null  comment '���Դ���3λСд',
   Name                 varchar(50)  comment '��������',
   EnName               varchar(50)  comment 'Ӣ������',
   LangName             varchar(50)  comment '��Ӧ���Ե�����',
   Status               int not null default 0  comment '״̬0-��ʼ1-����'
);

alter table s_language comment 'ϵͳ���Զ��壨ISO 639-1 �е�Сд˫��ĸ��
zh-cn �������ĺ�zh-tw��������';

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
   LogID                bigint not null auto_increment  comment '��־����GUID',
   Timestamp            datetime not null  comment '��־����ʱ��',
   Level                varchar(15)  comment '��־�ȼ�(Verbose|Debug|Information|Warning|Error|Fatal)',
   LevelNum             tinyint not null default 0  comment '��־�ȼ�����
             0-Verbose
             1-Debug
             2-Information
             3-Warning
             4-Error
             5-Fatal',
   Template             text  comment '��Ϣģ��',
   Message              text  comment '��Ϣ����',
   Exception            text  comment '�쳣',
   Properties           text  comment '����',
   ProjectID            varchar(100)  comment '�����ʶ',
   Environment          varchar(20)  comment '����',
   MachineIP            varchar(20)  comment '������IP',
   TemplateHash         bigint  comment '��Ϣģ��hash'
);

alter table s_log comment 'ϵͳ����־��';

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
   LogID                varchar(38) not null  comment '��־����(GUID)',
   UserID               varchar(38)  comment '�û�����',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   AppID                varchar(50)  comment 'Ӧ�ñ���',
   LoginDate            datetime  comment '��¼ʱ��',
   LogoutDate           datetime  comment '�˳�ʱ��',
   VersionID            varchar(100)  comment 'App�汾��',
   LangID               varchar(20)  comment '����',
   IsMobile             bool  comment '�Ƿ��ƶ���',
   OS                   varchar(20)  comment 'ϵͳ',
   Browser              varchar(20)  comment '�����',
   Status               int not null default 0  comment '״̬(0-ʧ��1-�ɹ�)',
   Message              text  comment '��Ϣ����������ԭ��',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table s_login_log comment 'ԭʼ�û���¼��־
��¼�ǳ�ʱ����������';

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
   MQLogID              varchar(36) not null  comment 'MQ�쳣��־����',
   MessageType          varchar(100)  comment '��Ϣ����',
   MessageLevel         tinyint not null default 0  comment '��Ϣ����Խ��Խ��Ҫ��',
   ProjectId            varchar(100)  comment '��Ŀ����',
   ActionName           varchar(100)  comment '��ӦAction',
   Exception            text  comment '�쳣��Ϣ',
   Status               int not null default 0  comment '��Ϣ״̬��0-��ʼ1-�쳣״̬2-�쳣�Ѵ���3-�쳣���账��',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table s_mq_log comment 'mqִ���쳣��־';

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
   OperatorID           varchar(50) not null  comment '��Ӫ�̱��루Сд��Ψһ��',
   OperatorBaseID       varchar(50) not null  comment '��Ӫ�̻������루Сд��Ψһ��',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   Langs                text  comment 'ƽ̨֧�ֵ����ԡ�|�ָ�',
   CurrencyID           varchar(5)  comment '�������ͣ�������дUSD��',
   LobbyUrl             varchar(255)  comment '�����ͻ�������URL',
   LobbyUrlStaging      varchar(255)  comment '�����ͻ��˷���URL',
   LobbyUrlDebug        varchar(255)  comment '�����ͻ��˵���URL',
   BankUrl              varchar(255)  comment '���пͻ�������URL',
   BankUrlStaging       varchar(255)  comment '���пͻ��˷���URL',
   BankUrlDebug         varchar(255)  comment '���пͻ��˵���URL',
   BranchKey            varchar(250)  comment 'branch�ؼ���',
   GAKey                varchar(250)  comment 'GA�ؼ���',
   Status               int not null default 0  comment '״̬(0-��Ч1-��Ч)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table s_operator comment '��Ӫ��';

alter table s_operator
   add primary key (OperatorID);

/*==============================================================*/
/* Table: s_operator_app                                        */
/*==============================================================*/
create table s_operator_app
(
   AppID                varchar(50) not null  comment 'Ӧ�ñ���',
   OperatorID           varchar(50) not null  comment '��Ӫ�̱���',
   OperatorAppId        varchar(100)  comment '��Ӧ����Ӫ��Ӧ�ñ���',
   AppUrl               text  comment 'Ӧ�ÿͻ�������URL',
   AppUrlStaging        text  comment 'Ӧ�ÿͻ��˷���URL',
   AppUrlDebug          text  comment 'Ӧ�ÿͻ�������URL',
   Status               int not null default 0  comment '״̬0-��Ч1-����2-ά����3-������',
   OperatorThumb        varchar(255)  comment '��ϷԤ��ͼurl',
   OperatorBg           varchar(255)  comment '��Ϸ����ͼurl',
   OperatorRoundUrl     varchar(255)  comment '��Ϸ�غ�url'
);

alter table s_operator_app comment '��Ӫ��Ӧ����Ȩ�����ʹ����ͬappid������ʹ���Զ���appid��';

alter table s_operator_app
   add primary key (AppID, OperatorID);

/*==============================================================*/
/* Table: s_operator_base                                       */
/*==============================================================*/
create table s_operator_base
(
   OperatorBaseID       varchar(50) not null  comment '��Ӫ�̻������루Сд��Ψһ��',
   OperatorName         varchar(100)  comment '��Ӫ������',
   OperatorType         int not null default 1  comment '��Ӫ������
             0-����
             1-���������û��г�ֵ
             2-���������û��޳�ֵ
             3-���������û��޳�ֵ',
   OperatorMode         int  comment '�����������(0-���1-����)',
   AllowVisitor         bool not null default 0  comment '�Ƿ������ο�',
   OperPublicKey        text  comment '��Ӫ�̹�Կ',
   OperPrivateKey       text  comment '��Ӫ��˽Կ�������ԣ�',
   OwnPublicKey         text  comment '�ҷ��Ĺ�Կ',
   OwnPrivateKey        text  comment '�ҷ���˽Կ',
   Note                 text  comment '��ע��Ϣ',
   SettlDayNum          int not null default 0  comment '�����գ���5��ʾÿ�½������5��',
   Status               int not null default 0  comment '״̬(0-��Ч1-��Ч)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��',
   OperAdminUrl         varchar(255)  comment '��Ӫ�̺�̨��ַ',
   OperAdminUser        varchar(50)  comment '��Ӫ�̺�̨�˺�',
   OperAdminPwd         varchar(255)  comment '��Ӫ�̺�̨����',
   CashAudit            int not null default 0  comment '�������ģʽ0-�����1-���'
);

alter table s_operator_base comment '��Ӧ�̻�������';

alter table s_operator_base
   add primary key (OperatorBaseID);

/*==============================================================*/
/* Table: s_provider                                            */
/*==============================================================*/
create table s_provider
(
   ProviderID           varchar(50) not null  comment 'Ӧ���ṩ�̱��루Сд��Ψһ������own',
   ProviderName         varchar(100)  comment 'Ӧ���ṩ������',
   ProviderType         int not null default 1  comment 'Ӧ���ṩ�����ͣ�0-���� 1-��������',
   ApiUrl               varchar(255)  comment '��ȡӦ�ÿͻ���URL��API·����Ӧ���ṩ���ṩ��',
   ApiUrlStaging        varchar(255)  comment '��ȡӦ�ÿͻ���URL��API·�������棩',
   ApiUrlDebug          varchar(255)  comment '��ȡӦ�ÿͻ���URL��API·����������',
   ProvPublicKey        text  comment 'Ӧ���ṩ�̹�Կ',
   ProvPrivateKey       text  comment 'Ӧ���ṩ��˽Կ�������ԣ�',
   OwnPublicKey         text  comment '�ҷ��Ĺ�Կ',
   OwnPrivateKey        text  comment '�ҷ���˽Կ',
   Mobile               varchar(50)  comment '�ֻ���',
   Email                varchar(100)  comment '����',
   Note                 text  comment '��ע��Ϣ',
   SettlDayNum          int not null default 0  comment '�����գ���5��ʾÿ�½������5��',
   Status               int not null default 0  comment '״̬(0-��Ч1-��Ч)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��',
   AdminUser            varchar(50)  comment '�ҷ��ṩ�ĺ�̨�˺�',
   AdminPwd             varchar(255)  comment '�ҷ��ṩ�ĺ�̨����',
   ProvAdminUrl         varchar(255)  comment 'Ӧ���ṩ�̺�̨��ַ',
   ProvAdminUser        varchar(50)  comment 'Ӧ���ṩ�̺�̨�˺�',
   ProvAdminPwd         varchar(255)  comment 'Ӧ���ṩ�̺�̨����'
);

alter table s_provider comment 'Ӧ���ṩ��';

alter table s_provider
   add primary key (ProviderID);

/*==============================================================*/
/* Table: s_provider_order                                      */
/*==============================================================*/
create table s_provider_order
(
   OrderID              varchar(38) not null  comment '��Ӧ���������ɵĶ������� GUID',
   ProviderID           varchar(50)  comment 'Ӧ���ṩ�̱���',
   AppID                varchar(50)  comment 'Ӧ�ñ���',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   UserID               varchar(38)  comment '�û�����(GUID)',
   UserKind             int not null default 0  comment '�û�����
             0-δ֪
             1-��ͨ�û�
             2-�����û�
             3-���ϲ����û������õ������ۼ���
             4-���ϲ����û��������õ������ۼ���
             5-�����û�
             6-�ӿ������û�
             9-����Ա',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '�������ͣ�������дRMB,USD��',
   CurrencyType         int not null default 0  comment '�������� 1-COIN 2--GOLD 3-POINT 4-SWB 8-������� 9-CASH',
   ReqMark              int not null default 0  comment '����ӿ����ͣ�0-balance1-Bet 2-Win 3-BetWin4-Rollback��',
   RequestUUID          varchar(38)  comment '����Ψһ��',
   ProviderOrderId      varchar(50)  comment 'Ӧ���ṩ�̶�������(TransactionUUID)',
   ReferProviderOrderId varchar(50)  comment 'Ӧ���ṩ��ԭʼ��������(ReferenceTransactionUUID)',
   RoundClosed          bool not null default 1  comment '�غ��Ƿ�ر�',
   RoundId              varchar(50)  comment '�غϱ�ʶ',
   RewardUUID           varchar(50)  comment '�ҷ��ṩ�Ľ���id',
   IsFree               bool not null default 0  comment '�Ƿ���������Ľ���',
   PlanBet              bigint not null default 0  comment '�ƻ���ע������������',
   PlanWin              bigint not null default 0  comment '�ƻ�����������������',
   PlanAmount           bigint not null default 0  comment '�ƻ��˻��仯��������������',
   Meta                 text  comment '��չ����',
   Status               int not null default 0  comment '״̬0-��ʼ1-������2-�ɹ�3-ʧ��4-�ѻع�5-�쳣���账��6-�쳣�Ѵ���',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '����ʱ��',
   ResponseTime         datetime  comment '����ʱ��',
   ResponseStatus       varchar(255)  comment '����״̬',
   Amount               bigint not null default 0  comment 'ʵ���˻��仯��������������',
   EndBalance           bigint not null default 0  comment '��������',
   SettlTable           varchar(100)  comment '�������',
   SettlId              varchar(50)  comment '�������',
   SettlAmount          bigint not null default 0  comment '������(������)',
   SettlStatus          int not null default 0  comment '����״̬��0-δ����1-�ѽ��㣩'
);

alter table s_provider_order comment 'Ӧ���ṩ�̵����ҷ��ӿڶ���';

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
   TransLogID           varchar(38) not null  comment '����Ӧ����־����(GUID)',
   OrderID              varchar(38)  comment '��Ӧ���������ɵĶ������� GUID',
   ProviderID           varchar(50)  comment 'Ӧ���ṩ�̱���',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   TransType            int not null default 0  comment 'ͨѶ����(0-�ҷ�����1-�Է�����)',
   TransMark            varchar(255)  comment 'ͨѶ��ǣ��ӿڱ�ʶ��',
   RequestTime          datetime not null  comment '����ʱ��',
   RequestBody          text  comment '������Ϣ���ҷ������Է�����json',
   Status               int not null default 0  comment '��Ϣ״̬��0-��ʼ1-���سɹ�2-����ʧ�ܣ�',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��',
   ResponseTime         datetime  comment '����ʱ��',
   ResponseBody         text  comment '��Ӧ��Ϣ���Է���Ӧ���ҷ���Ӧ��json',
   Exception            text  comment '�쳣��Ϣ'
);

alter table s_provider_trans_log comment '��Ӧ���ṩ��ͨѶ��־';

alter table s_provider_trans_log
   add primary key (TransLogID);

/*==============================================================*/
/* Table: s_settings                                            */
/*==============================================================*/
create table s_settings
(
   SettingsKey          varchar(200) not null  comment '���ü�������Сд��ProjectID:XXX:XXX��',
   Environment          varchar(100) not null  comment '��������',
   SettingsValue        varchar(255)  comment '����ֵ'
);

alter table s_settings comment 'Ӧ�ó������ñ�';

alter table s_settings
   add primary key (SettingsKey, Environment);

/*==============================================================*/
/* Table: s_user                                                */
/*==============================================================*/
create table s_user
(
   UserID               varchar(38) not null  comment '�û�����(GUID)',
   UserMode             int not null default 1  comment '�û���¼ģʽ 1-�ο� 2-ע���û�',
   Nickname             varchar(50)  comment '�ǳ�',
   FromMode             int not null default 0  comment '���û���Դ��ʽ
             0-�����Ӫ�̵����û�(s_operator)
             1-�ƹ�Ա��õ����û���userid��uid=xxx
             2-�ƹ�����ͨ��url��õ����û���s_channel)  cid=xxx',
   FromId               varchar(100)  comment '��Ӧ�ı��루����FromMode�仯��
             FromMode=
             0-��Ӫ�̵����û�(s_operator)==> OperatorID
             1-�ƹ�Ա��õ����û���userid�� ==> �����˵�UserID
             2-�ƹ�����ͨ��url��õ����û���s_channel_url) ==> CUrlID
             3-�ƹ�����ͨ��code��õ����û���s_channel_code) ==> CCodeID',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   OperatorUserId       varchar(50)  comment '��Ӫ���û���ʶ���û�������
             �ҷ���Ӫ��Ϊnull',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '��������',
   Cash                 bigint not null default 0  comment '�ֽ�һ�����ң�*100000',
   Coin                 bigint not null default 0  comment 'Ӳ�ң��������ң�',
   Gold                 bigint not null default 0  comment '���',
   Point                bigint not null default 0  comment '����',
   SWB                  bigint not null default 0  comment '�����',
   UserKind             int not null default 0  comment '�û�����
             0-δ֪
             1-��ͨ�û�
             2-�����û�
             3-���ϲ����û������õ������ۼ���
             4-���ϲ����û��������õ������ۼ���
             5-�����û�
             6-�ӿ������û�
             9-����Ա',
   IMEI                 varchar(20)  comment 'IMEI',
   GAID                 varchar(36)  comment 'GAID',
   Status               int not null default 0  comment '״̬
             0-δ֪
             1-��Ч
             2-�û������쳣���
             9-ϵͳ���',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��',
   RegistDate           datetime  comment 'ע��ʱ��',
   LastLoginDate        datetime not null default CURRENT_TIMESTAMP  comment '���һ�ε�¼ʱ��',
   Mobile               varchar(50)  comment '�ֻ���',
   Email                varchar(100)  comment '����',
   Username             varchar(50)  comment '��¼�û���',
   Password             varchar(255)  comment '�����ϣֵ',
   PasswordSalt         varchar(40)  comment '�����ϣSalt',
   HasBet               bool not null default 0  comment '�Ƿ��¹�ע',
   HasPay               bool not null default 0  comment '�Ƿ���ֵ',
   HasCash              bool not null default 0  comment '�Ƿ������'
);

alter table s_user comment '�û���';

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
   DayID                date not null  comment 'ͳ����',
   UserID               varchar(38) not null  comment '�û�����(GUID)',
   UserKind             int not null default 0  comment '�û�����
             0-δ֪
             1-��ͨ�û�
             2-�����û�
             3-���ϲ����û������õ������ۼ���
             4-���ϲ����û��������õ������ۼ���
             5-�����û�
             6-�ӿ������û�
             9-����Ա',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '�������ͣ����ֽ���������ͳ�ƣ�',
   IsNew                bool not null default 0  comment '�Ƿ����û�',
   IsRegister           bool not null default 0  comment '�����Ƿ������ע��',
   RegistDate           datetime  comment 'ע��ʱ��',
   IsLogin              bool not null default 0  comment '�����Ƿ��¼',
   IsNewPay             bool not null default 0  comment '�Ƿ��ǵ�һ�γ�ֵ�û�',
   IsNewBet             bool not null default 0  comment '�Ƿ��ǵ�һ����ע�û�',
   IsNewCash            bool not null default 0  comment '�Ƿ��һ�������û�',
   HasCash              bool not null default 0  comment '�����Ƿ���������Ϊ',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table s_user_day comment '�û�ÿ��ͳ��';

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
   UserID               varchar(38) not null  comment '�û�����(GUID)',
   UserKind             int not null default 0  comment '�û�����
             0-δ֪
             1-��ͨ�û�
             2-�����û�
             3-���ϲ����û������õ������ۼ���
             4-���ϲ����û��������õ������ۼ���
             5-�����û�
             6-�ӿ������û�
             9-����Ա',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '�������ͣ����ֽ���������ͳ�ƣ�',
   TotalBetAmount       bigint not null default 0  comment '��ע�ܶ�',
   TotalWinAmount       bigint not null default 0  comment '�����ܶ�',
   TotalPayAmount       bigint not null default 0  comment '��ֵ�ܶ�',
   TotalCashAmount      bigint not null default 0  comment '�����ܶ�'
);

alter table s_user_ex comment '�û�ʵʱ����';

alter table s_user_ex
   add primary key (UserID);

/*==============================================================*/
/* Table: sc_app_currency_chips                                 */
/*==============================================================*/
create table sc_app_currency_chips
(
   AppID                varchar(50) not null  comment 'Ӧ�ñ���',
   CurrencyID           varchar(5) not null  comment '��������',
   Chips                decimal not null default 0  comment '��������'
);

alter table sc_app_currency_chips comment 'app��ʹ�õĻ��ҵĳ��붨��';

alter table sc_app_currency_chips
   add primary key (AppID, CurrencyID, Chips);

/*==============================================================*/
/* Table: sc_banner                                             */
/*==============================================================*/
create table sc_banner
(
   BannerID             varchar(38) not null  comment 'Banner����GUID',
   AppID                varchar(50)  comment 'Ӧ�ñ���',
   OperatorID           varchar(50)  comment '��Ӫ�̱��루null��ζ��Ĭ�ϣ�',
   Position             int not null default 0  comment 'ʹ��λ�ã�app�ͻ��˷ֱ��Զ��壩',
   LangID               varchar(20)  comment '���Դ��루null��ζ��Ĭ�ϣ�',
   Title                varchar(500)  comment '����',
   Tip                  varchar(500)  comment '��ʾ��Ϣ',
   Content              varchar(1000)  comment '����',
   ImageUrl             varchar(500)  comment 'ͼƬ��ַ',
   LinkType             int not null default 0  comment '��������1-��Ե�ַ2-���Ե�ַ3-��Ϸ��ַ',
   LinkUrl              varchar(500)  comment '���ӵ�ַ',
   LinkParams           text  comment '���ܴ��ڵ����Ӳ�����ʽ(json)',
   OrderNum             int not null default 0  comment '���򣨴�С����',
   Status               int not null default 0  comment '״̬(0-��Ч1-��Ч)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table sc_banner comment '���λ����';

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
   CashAuditID          varchar(36) not null  comment '����guid',
   UserID               varchar(36) not null  comment '�û�����(GUID)',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '��������',
   Mobile               varchar(50) not null  comment '�ֻ���',
   Amount               bigint not null default 0  comment '�����',
   BankCode             varchar(50)  comment '���д���',
   BankName             varchar(100)  comment '��������',
   AccName              varchar(50)  comment '�û��˻�����',
   AccNumber            varchar(50) not null  comment '�û��˺ţ����п��ŵȣ�',
   Channels             int not null default 0  comment '�������0-���п�',
   Status               int not null default 0  comment '������״̬0-������1-ͨ��2-�ܾ�',
   ApplyTime            datetime not null default CURRENT_TIMESTAMP  comment '����ʱ��',
   AuditTime            datetime  comment '����ʱ��',
   OperatorUser         varchar(50)  comment '������'
);

alter table sc_cash_audit comment '������';

alter table sc_cash_audit
   add primary key (CashAuditID);

/*==============================================================*/
/* Table: sc_cash_audit_log                                     */
/*==============================================================*/
create table sc_cash_audit_log
(
   AuditLogID           varchar(36) not null  comment 'GUID',
   CashAuditID          varchar(36)  comment '����guid',
   Action               int not null default 0  comment '����0-�ύ����1-����ͨ��2-�����ܾ�',
   OperatorId           varchar(36) not null  comment '������ID',
   OperatorName         varchar(50) not null  comment '������',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table sc_cash_audit_log
   add primary key (AuditLogID);

/*==============================================================*/
/* Table: sc_marquee                                            */
/*==============================================================*/
create table sc_marquee
(
   MarqueeID            varchar(38) not null  comment '����Ʊ���GUID',
   AppID                varchar(50)  comment 'Ӧ�ñ���',
   OperatorID           varchar(50)  comment '��Ӫ�̱��루null��ζ��Ĭ�ϣ�',
   Position             int not null default 0  comment 'ʹ��λ�ã�app�ͻ��˷ֱ��Զ��壩',
   LangID               varchar(20)  comment '���Դ��루null��ζ��Ĭ�ϣ�',
   UserScope            int not null default 0  comment '��Χ����0-ȫ���û�1-�ض��û�',
   OrderNum             int not null default 0  comment '����ԽСԽ��ǰ��',
   MessageType          int not null default 0  comment '��Ϣ����1-ϵͳ֪ͨ2-�û��н���Ϣ',
   MessageContent       text  comment '��Ϣ����
             ��ϲ{nickname}��{appName}��Ӯ��{win}',
   MessageParams        text  comment '��Ϣ������������Ϣ���ͱ仯��
             MessageType=2: {nickname:''xxx'',appId:''lobby'',appName:''����'',win:1000}',
   BeginDate            datetime not null default '2000-01-01'  comment '��ʼ���ڣ�Ĭ��2016-01-01��',
   EndDate              datetime not null default '9999-12-31'  comment '��ֹ���ڣ�Ĭ��2099-01-01��',
   ProviderID           varchar(50)  comment 'Ӧ���ṩ�̱���',
   Status               int not null default 0  comment '״̬(0-��Ч1-��Ч)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table sc_marquee comment 'ϵͳ����ƣ�ֻ����ϵͳ�̶���Ϣ����������redis��';

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
   MarqueeID            varchar(38) not null  comment '����Ʊ���GUID',
   UserID               varchar(38) not null  comment '�û�����(GUID)'
);

alter table sc_marquee_user comment '����ƾ����û�';

alter table sc_marquee_user
   add primary key (MarqueeID, UserID);

/*==============================================================*/
/* Table: sc_notify                                             */
/*==============================================================*/
create table sc_notify
(
   NotifyID             varchar(38) not null  comment '����GUID',
   AppID                varchar(50)  comment 'Ӧ�ñ���',
   OperatorID           varchar(50)  comment '��Ӫ�̱��루null��ζ��ȫ����',
   ActionAt             int not null default 0  comment '��ʱ��ʾ1-��¼ǰ2-ע����һ�ε�¼3��¼��',
   ShowAt               int not null default 0  comment '��ʾҳ��FLAGֵ0-ȫ��1-��ҳ2-4-8',
   UserScope            int not null default 0  comment '�û���Χ0-ȫ���û�1-ָ�������û�',
   Position             int not null default 0  comment '��ʾλ��1-����2-�в�3-�²�',
   ShowTimes            int not null default 0  comment 'չʾ����',
   ShowInterval         int not null default 0  comment 'չʾ��������ӣ�',
   CloseInterval        int not null default 0  comment '�Զ��رռ�����룩0-�ֶ��ر�',
   LinkKind             int not null default 0  comment '��������1-email 2-url',
   LinkUrl              varchar(500)  comment '���ӵ�ַ',
   OrderNum             int not null default 0  comment '���򣨴�С����',
   BeginDate            datetime not null default '2000-01-01'  comment '��ʼ���ڣ�Ĭ��2016-01-01��',
   EndDate              datetime not null default '9999-12-31'  comment '��ֹ���ڣ�Ĭ��2099-01-01��',
   Status               int not null default 0  comment '״̬(0-��Ч1-��Ч)',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table sc_notify comment '֪ͨ';

alter table sc_notify
   add primary key (NotifyID);

/*==============================================================*/
/* Table: sc_notify_detail                                      */
/*==============================================================*/
create table sc_notify_detail
(
   NotifyID             varchar(38) not null  comment '����GUID',
   LangID               varchar(20) not null  comment '���Դ���',
   Title                varchar(255)  comment '����',
   ImageUrl             varchar(500)  comment 'ͼƬ��ַ',
   Content              text  comment '����',
   Txt1                 varchar(500)  comment '�ı�1',
   Txt2                 varchar(500)  comment '�ı�1',
   Txt3                 varchar(500)  comment '�ı�1',
   Txt4                 varchar(500)  comment '�ı�1',
   Txt5                 varchar(500)  comment '�ı�1',
   Img1                 varchar(500)  comment 'ͼƬ1',
   Img2                 varchar(500)  comment 'ͼƬ1',
   Img3                 varchar(500)  comment 'ͼƬ1',
   Img4                 varchar(500)  comment 'ͼƬ1',
   Img5                 varchar(500)  comment 'ͼƬ1'
);

alter table sc_notify_detail comment '֪ͨ��ϸ';

alter table sc_notify_detail
   add primary key (NotifyID, LangID);

/*==============================================================*/
/* Table: sc_notify_user                                        */
/*==============================================================*/
create table sc_notify_user
(
   NotifyID             varchar(38) not null  comment '����GUID',
   UserID               varchar(38) not null  comment '�û�����'
);

alter table sc_notify_user comment '֪ͨ�����û�';

alter table sc_notify_user
   add primary key (UserID, NotifyID);

/*==============================================================*/
/* Table: sc_notify_user_log                                    */
/*==============================================================*/
create table sc_notify_user_log
(
   NotifyID             varchar(38) not null  comment '����GUID',
   UserID               varchar(38) not null  comment '�û�����(GUID)',
   ShowCount            int not null default 0  comment '��ʾ����',
   LastShowDate         datetime not null default CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP  comment '���һ��չʾʱ��'
);

alter table sc_notify_user_log comment '֪ͨ�û���־';

alter table sc_notify_user_log
   add primary key (NotifyID, UserID);

/*==============================================================*/
/* Table: sc_user_app                                           */
/*==============================================================*/
create table sc_user_app
(
   UserID               varchar(38) not null  comment '�û�����',
   AppID                varchar(50) not null  comment 'Ӧ�ñ���',
   GuideNum             int not null default 0  comment '�û�������ʾ����',
   UserAppStatus        int not null default 0  comment '�û�״̬(0-δ֪1-����2-�쳣��',
   LastLoginDate        datetime  comment '���һ�η���ʱ��'
);

alter table sc_user_app comment '�û�����Ӧ�õ�����';

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
   SmsID                varchar(50) not null  comment '�����̱���',
   Name                 varchar(50)  comment '����',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table sm_sms comment '������';

alter table sm_sms
   add primary key (SmsID);

/*==============================================================*/
/* Table: sm_sms_order                                          */
/*==============================================================*/
create table sm_sms_order
(
   OrderID              varchar(38) not null  comment '����ID GUID',
   SmsID                varchar(50)  comment '�����̱���',
   ProviderID           varchar(50)  comment 'Ӧ���ṩ�̱���',
   AppID                varchar(50)  comment 'Ӧ�ñ���',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   UserID               varchar(38)  comment '�û�����(GUID)',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '��������',
   TemplateID           varchar(50) not null  comment 'ģ��ID',
   Content              text  comment '����',
   RequestTime          datetime not null  comment '����ʱ��',
   RequestBody          text  comment '������Ϣ���ҷ������Է�����json',
   Status               int not null default 0  comment '״̬0-��ʼ1-������2-�ɹ�3-ʧ��4-�ѻع�5-�쳣���账��6-�쳣�Ѵ���',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��',
   SmsOrderId           varchar(50)  comment '�����̶�������',
   ResponseTime         datetime  comment '����ʱ��',
   ResponseBody         text  comment '��Ӧ��Ϣ���Է���Ӧ���ҷ���Ӧ��json',
   Exception            text  comment '�쳣��Ϣ',
   SettlTable           varchar(100)  comment '�������',
   SettlId              varchar(50)  comment '�������',
   SettlStatus          int not null default 0  comment '����״̬��0-δ����1-�ѽ��㣩'
);

alter table sm_sms_order comment 'sms����';

alter table sm_sms_order
   add primary key (OrderID);

/*==============================================================*/
/* Table: sm_template                                           */
/*==============================================================*/
create table sm_template
(
   TemplateID           varchar(50) not null  comment 'ģ��ID',
   Name                 varchar(50)  comment '����',
   SelectMode           int not null default 0  comment 'ѡȡ����0-OrderNum'
);

alter table sm_template comment '����ģ��';

alter table sm_template
   add primary key (TemplateID);

/*==============================================================*/
/* Table: sm_template_lang                                      */
/*==============================================================*/
create table sm_template_lang
(
   TempLangID           varchar(36) not null  comment '����GUID',
   TemplateID           varchar(50) not null  comment 'ģ��ID',
   LangID               varchar(20)  comment '����',
   Content              text  comment '����'
);

alter table sm_template_lang comment '������Ӫ�̿ɷ��͵�ģ��';

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
   SmsTemplateID        varchar(36) not null  comment '����GUID',
   TemplateID           varchar(50)  comment 'ģ��ID',
   OperatorID           varchar(50)  comment '��Ӫ�̱��루Сд��Ψһ��',
   SmsID                varchar(50)  comment '�����̱���',
   OrderNum             int not null default 0  comment '���򣬴�С����'
);

alter table sm_template_sms comment 'ģ��ʹ�õĹ�Ӧ�̶����';

alter table sm_template_sms
   add primary key (SmsTemplateID);

/*==============================================================*/
/* Table: sp_hub88_currency                                     */
/*==============================================================*/
create table sp_hub88_currency
(
   TrdCurrencyID        varchar(20) not null  comment '�Է�currencyId',
   CurrencyID           varchar(20)  comment '��������',
   Name                 varchar(50)  comment '��������'
);

alter table sp_hub88_currency comment 'hub88���ҷ���֧�ֵĻ��ұ����Ӧ��ϵ�б�';

alter table sp_hub88_currency
   add primary key (TrdCurrencyID);

/*==============================================================*/
/* Table: sp_pgsoft_currency                                    */
/*==============================================================*/
create table sp_pgsoft_currency
(
   TrdCurrencyID        varchar(20) not null  comment '�Է�currencyId',
   CurrencyID           varchar(20) not null  comment '��������',
   Name                 varchar(50)  comment '��������',
   BaseUnit             int  comment '������λ'
);

alter table sp_pgsoft_currency comment '�ṩ�̻��һ�����λ';

alter table sp_pgsoft_currency
   add primary key (TrdCurrencyID);

/*==============================================================*/
/* Table: sr_app_user_rank                                      */
/*==============================================================*/
create table sr_app_user_rank
(
   AppID                varchar(50)  comment 'Ӧ�ñ���',
   UserID               varchar(38) not null  comment '�û�����(GUID)',
   Mobile               varchar(50)  comment '�ֻ���',
   BetAmount            int not null default 0  comment '��ע����',
   WinAmount            int not null default 0  comment 'Ӯ����'
);

alter table sr_app_user_rank comment 'app�û���Ӯ����(500��)';

/*==============================================================*/
/* Table: sr_oper_bank_paytype_day                              */
/*==============================================================*/
create table sr_oper_bank_paytype_day
(
   DayID                date not null  comment 'ͳ����',
   OperatorID           varchar(50) not null  comment '��Ӫ�̱���',
   BankID               varchar(50) not null  comment '���б���',
   PaytypeID            int not null default 0  comment '֧����ʽ0-�ۺ�1-visa2-spei',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '��������',
   PayUsers             int not null default 0  comment '��ֵ�û���',
   CashUsers            int not null default 0  comment '�����û���',
   PayOwnFee            decimal(20,2) not null default 0  comment '��ֵ�ҷ�������',
   PayUserFee           decimal(20,2) not null default 0  comment '��ֵ�û�������',
   CashOwnFee           decimal(20,2) not null default 0  comment '�����ҷ�������',
   CashUserFee          decimal(20,2) not null default 0  comment '�����û�������',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table sr_oper_bank_paytype_day comment '����֧����ʽÿ��ͳ��';

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
   DayID                date not null  comment 'ͳ����',
   OperatorID           varchar(50) not null  comment '��Ӫ�̱���',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5) not null  comment '�������ͣ����ֽ���������ͳ�ƣ�',
   NewUsers             int not null default 0  comment '�����û���DNU',
   LoginUsers           int not null default 0  comment '��¼�û�DAU',
   RegUsers             int not null default 0  comment 'ע���û���',
   BetUsers             int not null default 0  comment '��ע�û���',
   NewBetUsers          int not null default 0  comment '����ע�û���',
   NewUserBetAmount     bigint not null default 0  comment '���û���ע��',
   BetAmount            bigint not null default 0  comment '��ע����',
   WinAmount            bigint not null default 0  comment '��������',
   PayUsers             int not null default 0  comment '��ע�û���',
   NewPayUsers          int not null default 0  comment '����ע�û���',
   PayNotBetUsers       int not null default 0  comment '��ֵδ��ע�û�����',
   PayOwnFee            decimal(20,2) not null default 0  comment '��ֵ�ҷ�������',
   PayUserFee           decimal(20,2) not null default 0  comment '��ֵ�û�������',
   NewUserPayAmount     bigint not null default 0  comment '���û���ֵ��',
   PayAmount            bigint not null default 0  comment '��ֵ����',
   CashUsers            int not null default 0  comment '�����û���',
   NewCashUsers         int not null default 0  comment '�������û���',
   CashOwnFee           decimal(20,2) not null default 0  comment '�����ҷ�������',
   CashUserFee          decimal(20,2) not null default 0  comment '�����û�������',
   NewUserCashAmount    bigint not null default 0  comment '���û����ֶ�',
   CashAmount           bigint not null default 0  comment '��������',
   ProfitAmount         bigint not null default 0  comment 'ӯ������GGR����ע-����-���',
   PromotionFeeAmount   bigint not null default 0  comment '��ɱ�sum��s_currency_change.Amount��',
   NewARUP              float not null default 0  comment '���û�ARUP������ע�û���/���û���ע-�����ܶ',
   ARUP                 float not null default 0  comment 'ARUP',
   RetentionD1          float not null default 0  comment '1��������',
   RetentionD3          float not null default 0  comment '1��������',
   RetentionD7          float not null default 0  comment '1��������',
   RetentionD15         float not null default 0  comment '1��������',
   RetentionD30         float not null default 0  comment '1��������',
   RegRetentionD1       float not null default 0  comment 'ע��1��������',
   RegRetentionD3       float not null default 0  comment '1��������',
   RegRetentionD7       float not null default 0  comment '1��������',
   RegRetentionD15      float not null default 0  comment '1��������',
   RegRetentionD30      float not null default 0  comment '1��������',
   Lose10               int not null default 0  comment '��10',
   Lose10_100           int not null default 0  comment '��10-100����',
   Lose100_500          int not null default 0  comment '��10-100����',
   Lose500_1000         int not null default 0  comment '��10-100����',
   Lose1000_3000        int not null default 0  comment '��10-100����',
   Lose3000_5000        int not null default 0  comment '��10-100����',
   Lose5000_10000       int not null default 0  comment '��10-100����',
   Lose10000_50000      int not null default 0  comment '��10-100����',
   Lose50000            int not null default 0  comment '��10-100����',
   Win10                int not null default 0  comment '��10',
   Win10_100            int not null default 0  comment '��10-100����',
   Win100_500           int not null default 0  comment '��10-100����',
   Win500_1000          int not null default 0  comment '��10-100����',
   Win1000_3000         int not null default 0  comment '��10-100����',
   Win3000_5000         int not null default 0  comment '��10-100����',
   Win5000_10000        int not null default 0  comment '��10-100����',
   Win10000_50000       int not null default 0  comment '��10-100����',
   Win50000             int not null default 0  comment '��10-100����',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table sr_oper_day comment 'ÿ��ͳ�����ݣ�ÿ��ͳ�ƣ�';

alter table sr_oper_day
   add primary key (DayID, OperatorID);

/*==============================================================*/
/* Table: sr_user_day                                           */
/*==============================================================*/
create table sr_user_day
(
   DayID                date not null  comment 'ͳ����',
   UserID               varchar(38) not null  comment '�û�����(GUID)',
   OperatorID           varchar(50)  comment '��Ӫ�̱���',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '�������ͣ����ֽ���������ͳ�ƣ�',
   BetAmount            bigint not null default 0  comment '�����û���ע��',
   WinAmount            bigint not null default 0  comment '�����û�������',
   PayAmount            bigint not null default 0  comment '�����û���ֵ��',
   CashAmount           bigint not null default 0  comment '�����û����ֶ�',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table sr_user_day
   add primary key (DayID, UserID);

/*==============================================================*/
/* Table: sr_user_settl_day                                     */
/*==============================================================*/
create table sr_user_settl_day
(
   UserID               varchar(38) not null  comment '�û�����(GUID)',
   CurrencyID           varchar(20) not null  comment '��������',
   SumDay               date not null  comment 'ͳ����',
   BatchID              varchar(38)  comment '����ID',
   BetSum               bigint not null default 0  comment '��ע���',
   WinSum               bigint not null default 0  comment '�������',
   AmountSum            bigint not null default 0  comment '�������������=����-��ע',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table sr_user_settl_day comment '�û�ÿ�ս�������';

alter table sr_user_settl_day
   add primary key (SumDay, CurrencyID, UserID);

/*==============================================================*/
/* Table: src_push_config                                       */
/*==============================================================*/
create table src_push_config
(
   CfgID                varchar(36) not null  comment '��Key',
   OperatorID           varchar(50) not null  comment '��Ӫ�̱���',
   CountryId            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '��������',
   GameTop              int  comment '��Ϸ��ӯ��/������limit',
   UserTop              int  comment '�û���ӯ��/������limit',
   ResetTime            datetime not null  comment '��������ʱ��',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table src_push_config comment '������ñ�';

alter table src_push_config
   add primary key (CfgID);

/*==============================================================*/
/* Table: src_push_message                                      */
/*==============================================================*/
create table src_push_message
(
   MessageID            varchar(36) not null  comment '����GUID',
   SummaryTime          datetime not null  comment '����ʱ��',
   OperatorID           varchar(50) not null  comment '��Ӫ�̱���',
   SummaryType          int not null default 0  comment 'ͳ������
             1��ƽ̨ÿ20���Ӿ���Ӯ
             2��appÿ20���Ӿ�ӯ��top
             3��appÿ20���Ӿ�����top
             4��ÿ20�����û���ӯ��top
             5��ÿ20�����û�������top
             6��ÿ20�����û���ֵ�ܶ�
             7��ÿ20�����û������ܶ�
             8��ƽ̨ÿСʱע���û�����
             9��ƽ̨ÿСʱ�û���ע����',
   CountryId            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(20)  comment '��������',
   AppID                varchar(50)  comment 'Ӧ�ñ���',
   UserID               varchar(36)  comment '�û�����(GUID)',
   ProfitAmount         bigint not null default 0  comment '��ӯ��',
   LossAmount           bigint not null default 0  comment '������',
   SumProfit            bigint not null default 0  comment '�ܾ�ӯ��',
   SumLoss              bigint not null default 0  comment '�ܾ�����',
   RegisterUsers        int not null default 0  comment 'ÿСʱע������',
   BetUsers             bigint not null default 0  comment 'ÿСʱ��ע�û�����',
   OrderNum             int not null default 0  comment '���򣬴�С����',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '��¼ʱ��'
);

alter table src_push_message comment '������Ϣ��';

alter table src_push_message
   add primary key (MessageID);

/*==============================================================*/
/* Table: src_withdrawal_config                                 */
/*==============================================================*/
create table src_withdrawal_config
(
   ConfigID             varchar(36) not null  comment '����guid',
   OperatorID           varchar(50) not null  comment '��Ӫ�̱���',
   CountryID            varchar(5)  comment '���ұ���ISO 3166-1��λ��ĸ ',
   CurrencyID           varchar(5)  comment '��������',
   IsAudit              int not null default 1  comment '�Ƿ�������������',
   RecDate              datetime not null default CURRENT_TIMESTAMP  comment '����ʱ��',
   ApplyTime            datetime not null default CURRENT_TIMESTAMP  comment '����ʱ��',
   AuditTime            datetime  comment '����ʱ��',
   OperatorUser         varchar(50)  comment '������'
);

alter table src_withdrawal_config comment '������ñ�';

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

