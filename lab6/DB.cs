using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class DB
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\kwa\\Documents\\GitHub\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        //SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\kwa\\Documents\\GitHub\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        // SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed) 
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SQLiteConnection getConnection()
        {
            return connection;
        }

        public DataTable SelectFromDB(string Sring)
        {
            openConnection();
            DataTable table = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();

            SQLiteCommand cmd = new SQLiteCommand(Sring, getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            closeConnection();
            return table;
        }

        public DataTable AuthSelectInBD(string loginUser, string passUser)
        {
            string sql = "SELECT *, Role.Name AS Rolename FROM User INNER JOIN Role ON User.id_Role = Role.id_Role WHERE Login = " + loginUser + " AND Password = " + passUser;
            DataTable table = SelectFromDB(sql);
            return table;
        }

        public DataTable ListMunicipalContractsSelect()
        {
            string sql = "SELECT * FROM Municipal_contract";
            DataTable table = SelectFromDB(sql);
            return table;
        }

        public DataTable ListOrganizationSelect()
        {
            string sql = "SELECT * FROM Organization";
            DataTable table = SelectFromDB(sql);
            return table;
        }
    }
}
