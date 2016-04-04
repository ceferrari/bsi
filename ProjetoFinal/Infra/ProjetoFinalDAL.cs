using System;
using System.Data.SqlClient;

namespace Infra
{
    public class ProjetoFinalDAL : IDisposable
    {
        public SqlConnection sqlConnection { get; private set; }

        public ProjetoFinalDAL()
        {
            sqlConnection = new SqlConnection(ConfigDB.Default.ProjetoFinalConnection);
            sqlConnection.Open();
        }

        public void Dispose()
        {
            sqlConnection.Close();
        }
    }
}
