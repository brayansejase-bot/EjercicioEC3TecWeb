using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia.Core.CustomEntities;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Core.Services
{
    public class CommentService : ICommentService
    {
        public readonly IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CommentsMade3MonthsAgo>> GetCommentMade3MonthAgoAsync()
        {
            var comments = await _unitOfWork.CommentRepository.GetCommentsMade3MonthsAgoAsync();

            return comments;
        }
    }
}
