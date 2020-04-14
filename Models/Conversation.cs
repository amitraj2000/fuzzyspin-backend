using System;
using System.Collections.Generic;

namespace FuzzySpin.Models
{
    public partial class Conversation
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long? CreatorId { get; set; }
        public long? ChannelId { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }

        public virtual Users Creator { get; set; }
    }
}
