using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia.Core.CustomEntities;
using SocialMedia.Core.Entities;
using SocialMedia.Core.QueryFilters;

namespace SocialMedia.Core.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserWithoutComment>> GetUserWithoutCommentAsync();
        Task<IEnumerable<UserComment3DistinctPost>> GetUserComment3DistincPostAsync();
    }
}
