﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Sharding
{
    public static class ShardingUtil
    {
        public static void ClearCaching()
        {
            SProviderOrderService.Clear();
        }
    }
}
