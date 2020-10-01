using PS.Template.Domain.Interfaces.Queries.Base;
using SqlKata.Compilers;
using System.Data;

namespace PS.Template.AccessData.Queries.Base
{
    public class BaseQuery<E> : IBaseQuery<E> 
    {
        protected readonly IDbConnection connection;
        protected readonly Compiler sqlKatacompiler;

        public BaseQuery(IDbConnection connection, Compiler sqlKatacompiler)
        {
            this.connection = connection;
            this.sqlKatacompiler = sqlKatacompiler;
        }        
    }
}