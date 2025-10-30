using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia.Core.CustomEntities;

namespace SocialMedia.Core.Interfaces
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentsMade3MonthsAgo>> GetCommentMade3MonthAgoAsync();
    }
}
