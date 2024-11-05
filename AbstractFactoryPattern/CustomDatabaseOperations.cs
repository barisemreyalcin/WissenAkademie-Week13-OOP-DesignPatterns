using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class CustomDatabaseOperations
    {
        IDatabaseFactory dbFactory;
        Connection connection;
        Command command;

        public CustomDatabaseOperations(IDatabaseFactory _dbFactory)
        {
            this.dbFactory = _dbFactory;
            connection = dbFactory.CreateConnection();
            command = dbFactory.CreateCommand();
        }

        public void RemoveById(int id)
        {
            connection.OpenConnection();
            command.ExecuteCommand("Delete User where UserID = " + id);
            connection.CloseConnection();
        }

        public void GetById(int id)
        {
            connection.OpenConnection();
            command.ExecuteCommand("Select * From User where UserID=" + id);
        }

        public void GetAll()
        {
            connection.OpenConnection();
            command.ExecuteCommand("Select * From User");
            connection.CloseConnection();
        }
    }
}
