using System.Data;
using DapperLib;

namespace DapperContrib144Issue
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = null;
            object entity = null;
            DapperContribWrapper.Insert(connection, entity);
        }
    }
}
