﻿using Dist.Common.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dist.Common
{
    public class AuthenticateUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
