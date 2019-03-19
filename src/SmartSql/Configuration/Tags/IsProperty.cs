﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SmartSql.Configuration.Tags
{
    public class IsProperty : Tag
    {
        public override bool IsCondition(RequestContext context)
        {
            return context.Parameters.ContainsKey(Property);
        }
    }
}
