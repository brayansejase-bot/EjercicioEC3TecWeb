using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Queries
{
    public class CommentQueries
    {
        public static string ComentariosRealizadosHace3Meses = @"
                SELECT 
            c.Id AS IdComment,
            c.Description AS CommentDescription,
            u.FirstName,
            u.LastName,
            DATEDIFF(YEAR, u.DateOfBirth, GETDATE()) AS Edad
        FROM Comment AS c
        INNER JOIN [User] AS u 
            ON c.UserId = u.Id
        WHERE 
            u.IsActive = 1
            AND DATEDIFF(YEAR, u.DateOfBirth, GETDATE()) > 25
            AND c.Date >= DATEADD(MONTH, -3, GETDATE());

        ";
    }
}
