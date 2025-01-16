using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Text;

namespace UGame.User.Service.Account.Register
{
    /// <summary>
    /// 长度需为 6 至 30 个字符
    /// 可以是字母、数字或.
    /// .不能作为开头或结尾
    /// .不能连续
    /// </summary>
    internal class UsernameFilter
    {
        private LimitedCharFilter _charFilter = new LimitedCharFilter(true, StringUtil.NumberLetterChars);
        private const int MIN_LENGTH = 6;
        private const int MAX_LENGTH = 30;

        public UsernameFilter()
        {
            _charFilter = new LimitedCharFilter(true);
            _charFilter.AddNumberChars();
            _charFilter.AddLetterChars();
            _charFilter.AddChar('.');
        }

        public bool IsValid(string value)
        {
            if (string.IsNullOrEmpty(value)
                || (value.Length < MIN_LENGTH || value.Length > MAX_LENGTH)
                || !_charFilter.IsValid(value)
                || (value.First() == '.' || value.Last() == '.'))
                return false;
            return value.IndexOf("..") < 0;
        }
    }
}
