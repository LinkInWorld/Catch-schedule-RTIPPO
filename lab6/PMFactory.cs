using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class PMFactory
    {

        public PM GetUserPM(User user)
        {
            if(user.role.name == "Куратор ВетСлужбы")
            {
                return new CuratorVebService(user);
            }
            return new CuratorVebService(user);
        }
    }
}
