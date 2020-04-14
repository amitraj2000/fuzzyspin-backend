using System;
using System.Collections.Generic;

namespace FuzzySpin.Models
{
    public partial class Users
    {
        public Users()
        {
            Conversation = new HashSet<Conversation>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicture { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }

        public virtual ICollection<Conversation> Conversation { get; set; }
    }
}
