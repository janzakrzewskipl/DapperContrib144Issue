using System.Data;
using Dapper.Contrib.Extensions;

namespace DapperLib
{
    public class DapperContribWrapper
    {
        public static void Insert<T>(IDbConnection connection, T entity) where T: class
        {
            connection.Insert(entity);
        }
    }
}
