using SocialMedia.Core.CustomEntities;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Exceptions;
using SocialMedia.Core.Interfaces;
using SocialMedia.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Services
{
    public class UserService : IUserService
    {
        public readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
        public async Task<IEnumerable<UserWithoutComment>> GetUserWithoutCommentAsync()
        {
            var users = await _unitOfWork.UserRepository.GetUserWithoutCommentAsync();

            return users;
        }
        public async Task<IEnumerable<UserComment3DistinctPost>> GetUserComment3DistincPostAsync()
        {
            var users = await _unitOfWork.UserRepository.GetUserComment3DistincPostAsync();

            return users;
        }
    }
}
