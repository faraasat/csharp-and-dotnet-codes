using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    // ISP full form is I Stored Procedure
    public interface ISP_Call : IDisposable
    {

        T Single<T>(string procedureName, DynamicParameters param = null);

        void Execute(string procedureName, DynamicParameters param = null);

        T OneRecord<T>(string procedureName, DynamicParameters param = null);

        IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null);

        // This is implementation for two tables
        Tuple<IEnumerable<T>, IEnumerable<U>> List<T, U>(string procedureName, DynamicParameters param = null);

    }
}
