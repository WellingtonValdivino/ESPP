namespace core.Domain.Interfaces
{
    using System.Collections.Generic;
    using MySql.Data.MySqlClient;
    
    public interface IRepositoryBase
    {
       MySqlConnection conn();
    }
}