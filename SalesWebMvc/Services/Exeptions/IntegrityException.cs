﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exeptions
{
    public class IntegrityException :ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
