using System;
using System.Data.SqlClient;

namespace Infra
{
    public class ProjetoFinalDAL : IDisposable
    {
        public SqlConnection Connection { get; private set; }

        public ProjetoFinalDAL()
        {
            Connection = new SqlConnection(ConfigDB.Default.ProjetoFinalConnection);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
