﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.Shared.Dtos
{
    public class PagingFilterDto
    {
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
