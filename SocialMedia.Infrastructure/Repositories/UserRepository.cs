using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Data;
using SocialMedia.Core.CustomEntities;
using SocialMedia.Infrastructure.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IDapperContext _dapper;

        //private readonly SocialMediaContext _context;
        public UserRepository(SocialMediaContext context,IDapperContext dapper): base(context) 
        {
            _dapper = dapper;
            //_context = context;
        }

        //public async Task<User> GetUserByIdAsync(int id)
        //{
         //   var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
          //  return user;
        //}


        public async Task<IEnumerable<UserWithoutComment>> GetUserWithoutCommentAsync()
        {
            try
            {
                var sql = UserQueries.UsuarioSinComentarios;

                return await _dapper.QueryAsync<UserWithoutComment>(sql);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public async Task<IEnumerable<UserComment3DistinctPost>> GetUserComment3DistincPostAsync()
        {
            try
            {
                var sql = UserQueries.UsuarioComentaronPostDistintos;

                return await _dapper.QueryAsync<UserComment3DistinctPost>(sql);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
