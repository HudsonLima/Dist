using System;
using System.Collections.Generic;
using System.Text;

namespace Dist.Common.Events
{
    public interface IAuthenticateEvent : IEvent
    {
        Guid UserId { get; }
    }
}
