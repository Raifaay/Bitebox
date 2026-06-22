using Bitebox.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.IABS
{
    public abstract class BaseContext
    {
        protected NpgsqlConnection GetConnection() // ini ngapain woi
        {
            return DatabaseConnection.GetConnection();
        }

        public abstract string GetNamaEntitas();
    }
}