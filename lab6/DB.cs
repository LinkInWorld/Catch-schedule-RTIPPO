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
        SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\kwa\\Desktop\\lab6\\lab6\\db.sqlite3");

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
            DataTable table = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();

            SQLiteCommand cmd = new SQLiteCommand(Sring, getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }
    }
}
