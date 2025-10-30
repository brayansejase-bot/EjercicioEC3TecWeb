using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia.Core.Entities;

namespace SocialMedia.Core.CustomEntities
{
    public class CommentsMade3MonthsAgo
    {
        public int IdComment { get; set; }  

        public string CommentDescription { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Edad { get; set; }
    }
}
