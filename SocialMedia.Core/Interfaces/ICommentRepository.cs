using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia.Core.CustomEntities;
using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Interfaces
{
    public interface ICommentRepository
    {
        Task<IEnumerable<CommentsMade3MonthsAgo>> GetCommentsMade3MonthsAgoAsync();
    }
}
