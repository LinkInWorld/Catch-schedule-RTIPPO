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
        static SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\kwa\\Documents\\GitHub\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        //SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\kwa\\Documents\\GitHub\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        // SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        public static void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed) 
                connection.Open();
        }

        public static void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public static SQLiteConnection getConnection()
        {
            return connection;
        }

        public static DataTable SelectFromDB(string Sring)
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

        public static DataTable AuthSelectInBD(string loginUser, string passUser)
        {
            string sql = "SELECT *, Role.Name AS Rolename FROM User INNER JOIN Role ON User.id_Role = Role.id_Role WHERE Login = " + loginUser + " AND Password = " + passUser;
            DataTable table = SelectFromDB(sql);
            return table;
        }

        public static DataTable ListMunicipalContractsSelect()
        {
            string sql = "SELECT * FROM Municipal_contract";
            DataTable table = SelectFromDB(sql);
            return table;
        }

        public static DataTable ListOrganizationSelect()
        {
            string sql = "SELECT * FROM Organization";
            DataTable table = SelectFromDB(sql);
            return table;
        }
    }
}
