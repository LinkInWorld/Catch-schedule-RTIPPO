using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class OperatorTrapping : PM
    {
        public OperatorTrapping(User user) : base(user) { }

        public override bool CanUpdate(object obj)
        {
            if (obj is MunicipalContract)
            {
                return false;
            }
            return false;
        }
    }
}
