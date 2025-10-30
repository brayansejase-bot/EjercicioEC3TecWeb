using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Queries
{
    public class UserQueries
    {
        

        public static string UsuarioSinComentarios = @"
                 SELECT
                u.FirstName,
                u.LastName,
                u.Email
            FROM [User] AS u
            LEFT JOIN Comment c
                ON u.Id = c.UserId
            WHERE
                u.IsActive = 1
                AND c.Id IS NULL;
            ";
        public static string UsuarioComentaronPostDistintos = @"
                    SELECT 
            u.FirstName,
            u.LastName,
            COUNT(DISTINCT p.UserId) AS UsuariosDiferentes
        FROM [User] AS u
        INNER JOIN Comment AS c 
            ON u.Id = c.UserId
        INNER JOIN Post AS p 
            ON c.PostId = p.Id
        WHERE 
            u.IsActive = 1
        GROUP BY 
            u.FirstName, 
            u.LastName
        HAVING 
            COUNT(DISTINCT p.UserId) >= 3;

        ";
    }
}
