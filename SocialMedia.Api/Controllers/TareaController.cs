using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Api.Responses;
using SocialMedia.Core.CustomEntities;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Core.QueryFilters;
using SocialMedia.Infrastructure.DTOs;
using SocialMedia.Infrastructure.Validators;
using System.Net;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase

    {
        private readonly IUserService _userService;
        private readonly IPostService _postService;
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        private readonly IValidationService _validationService;
        public TareaController(IUserService userService,
            IPostService postService,ICommentService commentService,
            IMapper mapper,
            IValidationService validationService)
        {
            _userService = userService;
            _postService = postService;
            _commentService = commentService;
            _mapper = mapper;
            _validationService = validationService;
        }

        [HttpGet("dapper/1")]
        public async Task<IActionResult> GetPostNoCommentUserAsync()
        {
            var posts = await _postService.GetPostNoCommentUserAsync();


            var response = new ApiResponse<IEnumerable<PostNoCommentUserActive>>(posts);

            return Ok(response);
        }
        [HttpGet("dapper/2")]
        public async Task<IActionResult> GetPostCommentMinorAgeAsync()
        {
            var posts = await _postService.GetPostCommenMinorAgeAsync();


            var response = new ApiResponse<IEnumerable<PostCommentMinorAge>>(posts);

            return Ok(response);
        }
        [HttpGet("dapper/3")]
        public async Task<IActionResult> GetUserWithoutCommentAsync()
        {
            var users = await _userService.GetUserWithoutCommentAsync();


            var response = new ApiResponse<IEnumerable<UserWithoutComment>>(users);

            return Ok(response);
        }
        [HttpGet("dapper/4")]
        public async Task<IActionResult> GetUserComment3DistinctPostAsync()
        {
            var users = await _userService.GetUserComment3DistincPostAsync();


            var response = new ApiResponse<IEnumerable<UserComment3DistinctPost>>(users);

            return Ok(response);
        }
        [HttpGet("dapper/5")]
        public async Task<IActionResult> GetCommentMade3MonthsAgoAsync()
        {
            var comments = await _commentService.GetCommentMade3MonthAgoAsync();


            var response = new ApiResponse<IEnumerable<CommentsMade3MonthsAgo>>(comments);

            return Ok(response);
        }
    }
}
