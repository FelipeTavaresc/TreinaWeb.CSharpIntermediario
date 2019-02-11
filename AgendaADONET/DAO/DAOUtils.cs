﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            //DbConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=TreinaWebCSharpIntermediario;User Id=sa;Password=865522;");
            DbConnection conexao = new MySqlConnection(@"Server=localhost;Database=treinawebcsharpintermediario;Uid=root;Pwd=865522;");
            conexao.Open();
            return conexao;
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }
    }
}
