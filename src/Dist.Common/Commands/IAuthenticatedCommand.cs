using System;
using System.Collections.Generic;
using System.Text;

namespace Dist.Common.Commands
{
    public interface IAuthenticatedCommand : ICommand
    {
        Guid UserId { get; set; }
    }
}
