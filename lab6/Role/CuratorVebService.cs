﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class CuratorVebService : PM
    {
        public CuratorVebService(User user): base(user) { }
        public override bool CanWatchAll(object obj)
        {
            if (obj is MunicipalContract)
            {
                return true;
            }
            return false;
        }
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
