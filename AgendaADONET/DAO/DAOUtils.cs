using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            DbConnection conexao = new SqlConnection("Server=.\SQLEXPRESS;Database=TreinaWebCSharpIntermediario;User Id=sa;Password=865522;");
        }
    }
}
