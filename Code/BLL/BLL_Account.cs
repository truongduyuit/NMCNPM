using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Account
    {
        #region prop
        private DAL_Account acc = new DAL_Account();
        #endregion
        #region method
        public int CheckLogin(string username, string password)
        {
            return acc.CheckLogin(username, password);
        }
        public int UpdateAccount(string username, string password) {
            return acc.UpdateAccount(username, password);
        }
        #endregion
    }
}
