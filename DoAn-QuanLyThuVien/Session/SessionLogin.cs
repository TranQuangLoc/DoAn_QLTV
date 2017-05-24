using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    public class SessionLogin
    {
        public static string SessionUsername = null;
        public static string SessionPassWord = null;

        public static bool IsLogin()
        {
            if (SessionUsername != null)
            {
                return true;
            }
            return false;
        }
    }
}
