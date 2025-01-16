using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Common
{
    /// <summary>
    /// 服务类型
    /// </summary>
    public enum ServerType
    {
        /// <summary>
        /// 普通服务
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 本机开发测试
        /// </summary>
        Dev = 1,
        /// <summary>
        /// 仿真
        /// </summary>
        Staging = 2,
        /// <summary>
        /// 联调
        /// </summary>
        JointDebug = 3
    }
}
