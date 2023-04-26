using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Common.Events
{
    public class MessageUpdateEvent : BaseEvent
    {
        public MessageUpdateEvent(string type) : base(nameof(MessageUpdateEvent))
        {
        }

        public string Message { get; set; }
    }
}