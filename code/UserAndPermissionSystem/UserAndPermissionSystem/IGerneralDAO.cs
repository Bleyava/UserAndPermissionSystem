using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndPermissionSystem
{
    public interface IGerneralDAO
    {
        void insertUser(User user);
        void updateUser(User user);
        void deleteUser(User user);
        void getUser(string username);
    }
}
