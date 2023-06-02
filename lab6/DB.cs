﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    internal class DB
    {
        //static SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Poldnik999\\source\\repos\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        static SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\kwa\\Documents\\GitHub\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        //static SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        static SQLiteCommand cmd;
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

            cmd = new SQLiteCommand(Sring, getConnection());

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


        // Илья
        public static DataTable ListOrganizationSelect()
        {
            string sql = "SELECT * FROM Organization";
            DataTable table = SelectFromDB(sql);
            return table;
        }

        // Никита

        public static string ExecuteQueryWithAnswer(string query)
        {
            openConnection();
            cmd.CommandText = query;
            var answer = cmd.ExecuteScalar();
            closeConnection();

            if (answer != null) return answer.ToString();
            else return null;
        }
        public static DataTable ListPlanScheduleSelect()
        {
            string sql = "SELECT [Plan_Schedule].id, [Locality].Name, [Plan_Schedule].Month, [Plan_Schedule].Year " +
                         "FROM Plan_Schedule, Locality " +
                         "WHERE [Plan_Schedule].id_Locality = [Locality].id_Locality ";
            DataTable table = SelectFromDB(sql);
            return table;
        }
        public static void ListPlanScheduleInsert(ArrayList record) 
        {
            DataTable table = SelectFromDB(
                "SELECT [Locality].id_Locality " +
                "FROM Locality " +
                "WHERE [Locality].Name = '" + record[0]+"'"
                );
            string sql = ExecuteQueryWithAnswer(
                "INSERT INTO Plan_Schedule (id_Locality, Month, Year) " +
                "VALUES ('" + table.Rows[0][0] + "', '" + record[1] + "', '" + record[2] + "');");
        }
        public static void ListPlanScheduleDelete(int idSelectedPlanSchedule) 
        {
            string sql = ExecuteQueryWithAnswer(
                "DELETE FROM Plan_Schedule " +
                "WHERE id = " + idSelectedPlanSchedule + ";");
        }
        public static void ListPlanScheduleUpdate(int idSelectedPlanSchedule, ArrayList record)
        {
            DataTable table = SelectFromDB(
                "SELECT [Locality].id_Locality " +
                "FROM Locality " +
                "WHERE [Locality].Name = '" + record[0] + "'"
                );
            string sql = ExecuteQueryWithAnswer(
                "UPDATE Plan_Schedule SET " +
                "id_Locality = '" + table.Rows[0][0] +"'," +
                "Month = '" + record[1] +"'," +
                "Year = '" + record[2] +"' " +
                "WHERE id = " + idSelectedPlanSchedule + ";");
        }
    }
}
