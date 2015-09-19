using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jdb.sundries
{
    class PropetyClass
    {
        private static string m_User;

        private static string m_PassWord;

        private static string m_IsAdmin;



        /// <summary>
        ///   操作员密码
        /// </summary>
        public static string PassWord
        {
            get { return m_PassWord; }
            set { m_PassWord = value; }
        }
        public static string User
        {
            get { return m_User; }
            set { m_User = value; }
        }
        /// <summary>
        ///   是否系统管理员标记
        /// </summary>
        public static string IsAdmin
        {
            get { return m_IsAdmin; }
            set { m_IsAdmin = value; }
        }
    }
}
