using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SocialMedia.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }
        IUserRepository UserRepository { get; }
        ICommentRepository CommentRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();

        Task BeginTransaccionAsync();
        Task CommitAsync();
        Task RollbackAsync();

        //Nuevos miembros de Dapper
        IDbConnection? GetDbConnection();
        IDbTransaction? GetDbTransaction();
    }
}