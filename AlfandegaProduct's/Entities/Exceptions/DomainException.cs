﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfandegaProduct_s.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string menssage) 
            : base(menssage) { }
    }
}
