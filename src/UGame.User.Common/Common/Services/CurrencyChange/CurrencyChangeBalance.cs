using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Common.Services
{
    public enum CurrencyChangeBalance
    {
        /// <summary>
        /// 当非货币的变化时
        /// </summary>
        None = 0,
        /// <summary>
        /// 增加或扣减货币时，真金变化
        /// </summary>
        Cash = 1,
        /// <summary>
        /// 增加或扣减货币时，bonus变化
        /// </summary>
        Bonus = 2,
        /// <summary>
        /// 扣减货币时，优先Bonus
        /// </summary>
        FirstBonus = 3,
        /// <summary>
        /// 扣减货币时，优先真金
        /// </summary>
        FirstCash = 4
    }
}
