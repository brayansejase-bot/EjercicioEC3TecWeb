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
    public class CommentRepository : ICommentRepository
    {
        private readonly IDapperContext _dapper;
        //private readonly SocialMediaContext _context;
        public CommentRepository(SocialMediaContext context, IDapperContext dapper)
        {
            _dapper = dapper;
            //_context = context;
        }   
        public async Task<IEnumerable<CommentsMade3MonthsAgo>> GetCommentsMade3MonthsAgoAsync()
        {
            try
            {
                var sql = CommentQueries.ComentariosRealizadosHace3Meses;

                return await _dapper.QueryAsync<CommentsMade3MonthsAgo>(sql);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
