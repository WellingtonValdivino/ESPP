
using Oracle.ManagedDataAccess.Client;
using core.Domain.Interfaces;
using System;
using System.Collections.Generic;

using System.Linq.Expressions;
using System.Data.SqlClient;


namespace core.Infra.Repository
{
    using core.Infra;
    using Microsoft.Extensions.Configuration;
    using System.Configuration;
    using MySql.Data.MySqlClient;
    
    public class RepositoryBase : IRepositoryBase
    {
        private readonly string _connectionString;

        public RepositoryBase(string connectionString)
        {
            _connectionString = connectionString;   // Injetando a string de conexão no construtor da classe
        }

        public MySqlConnection conn()
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);

            return connection;
        }
    }
}
