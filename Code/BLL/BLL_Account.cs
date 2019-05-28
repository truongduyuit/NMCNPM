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
        private DAL_Account acc = new DAL_Account();

        public int CheckLogin(string username, string password)
        {
            return acc.CheckLogin(username, password);
        } 
    }
}
