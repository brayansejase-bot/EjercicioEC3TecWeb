using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia.Core.Entities;

namespace SocialMedia.Core.CustomEntities
{
    public class UserWithoutComment

    {
        public UserWithoutComment() { }
        public string FirstName { get; set; } 

        public string LastName { get; set; } 

        public string Email { get; set; }

    }
}
