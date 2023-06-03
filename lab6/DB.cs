using System;
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
        static SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\Poldnik999\\source\\repos\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        //static SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\kwa\\Documents\\GitHub\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        //static SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Catch-schedule-RTIPPO\\lab6\\db.sqlite3");
        static SQLiteCommand cmd;
        static string sql;
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

        public static DataTable ListMunicipalContractsSelect(User user)
        {
            if( user.role == 4 || user.role == 3 || user.role == 2)
            {
                sql = "SELECT * FROM Municipal_contract";
            }
            else
            {
                sql = "SELECT * FROM Municipal_contract WHERE Customer ="+ user.idOrganization+ " OR Executor = " + user.idOrganization;
            }            
            DataTable table = SelectFromDB(sql);
            return table;
        }

        public static void SelectCreateMunicipalContract(ArrayList record)
        {
            /*DataTable table = SelectFromDB(
                "SELECT [Locality].id_Locality " +
                "FROM Locality " +
                "WHERE [Locality].Name = '" + record[0] + "'"
                );
            string sql = ExecuteQueryWithAnswer(
                "INSERT INTO Plan_Schedule (id_Locality, Month, Year) " +
                "VALUES ('" + table.Rows[0][0] + "', '" + record[1] + "', '" + record[2] + "');");*/
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

        //Добавление записи в бд по списку значений
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
        //Удаление записи из бд по id
        public static void ListPlanScheduleDelete(int idSelectedPlanSchedule) 
        {
            string sql = ExecuteQueryWithAnswer(
                "DELETE FROM Plan_Schedule " +
                "WHERE id = " + idSelectedPlanSchedule + ";");
        }
        // Редактирование таблицы по id и списку значений
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
        // Список населенных пунктов
        public static DataTable ListLocaitySelect()
        {
            string sql = "SELECT [Locality].Name FROM Locality";
            DataTable table = SelectFromDB(sql);
            return table;
        }
        //  Фильтр/сортировка
        //  Название столбца для сортировки задается в свойствах radioButton.Tag
        public static DataTable ListPlanScheduleFilterSelect(string filter, string sort)
        {
            string cellValue = "";
            string sql = "SELECT [Plan_Schedule].id, [Locality].Name, [Plan_Schedule].Month, [Plan_Schedule].Year " +
                        "FROM Plan_Schedule, Locality " +
                        "WHERE [Plan_Schedule].id_Locality = [Locality].id_Locality ";

            DataTable table = SelectFromDB(sql);
            table.Columns[0].ColumnName = "id";
            table.Columns[1].ColumnName = "Name";
            table.Columns[2].ColumnName = "Month";
            table.Columns[3].ColumnName = "Year";

            if(filter != "")
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        cellValue = table.Rows[i][j].ToString();
                        if (cellValue.Contains(filter))
                        {
                            if (table.Columns[j].ColumnName.ToString() != "Name")
                                sql += " AND [Plan_schedule]." + table.Columns[j].ColumnName.ToString() + " = '" + cellValue + "';";
                            else
                                sql += " AND [Locality]." + table.Columns[j].ColumnName.ToString() + " = '" + cellValue + "';";
                        }

                    }
                }
            
            table = SelectFromDB(sql);
            table.DefaultView.Sort = sort;
            return table;
        }
        public static DataTable ListDataPlanScheduleCard(string idSelectedPlanSchedule)
        {
            string sql = "SELECT [Plan_Schedule].id, [Locality].Name, [Plan_Schedule].Month, [Plan_Schedule].Year " +
                        "FROM Plan_Schedule, Locality " +
                        "WHERE [Plan_Schedule].id_Locality = [Locality].id_Locality AND [Plan_Schedule].id = '" + idSelectedPlanSchedule + "'";
            DataTable table = SelectFromDB(sql);
            return table;
        }
    }
}
