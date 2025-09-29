using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Dao
{
    public class UsarioDao
    {
        public String[] users = {"engel", "dominick", "oscar" };
        public String[] pws = { "123", "147", "159" };
        public Boolean Validar(String user, String pw)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Equals(user) && (pws[i].Equals(pw)))
                { return true; }
            }return false;  
        }
    }
}
