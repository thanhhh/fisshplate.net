﻿using System;
using System.Collections.Generic;

using System.Text;

namespace Seasar.Fisshplate.Core.Element
{
    public class ElseBlock : AbstractBlock
    {
        public override void Merge(Seasar.Fisshplate.Context.FPContext context)
        {
            MergeChildren(context);
        }
    }
}
