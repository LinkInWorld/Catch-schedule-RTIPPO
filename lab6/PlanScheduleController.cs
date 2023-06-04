using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class PlanScheduleController
    {
        public User user;
        public DataTable table = new DataTable();


        // получение таблицы из бд
        public DataTable getListPlanSchedule(User user) {   return DB.ListPlanScheduleSelect(user); }

        //Получение данных выбранной учетной карточки
        public DataTable getDataPlanScheduleCard(string idSelectedPlanSchedule){    return DB.ListDataPlanScheduleCard(idSelectedPlanSchedule); }

        //Удаление записи из бд
        public DataTable getListPlanScheduleDeleted(int idSelectedPlanSchedule)
        {

            DB.ListPlanScheduleDelete(idSelectedPlanSchedule);
            table = DB.ListPlanScheduleSelect(user);
            return table;
        }

        //Добавление записи в бд
        public DataTable getListPlanScheduleInserted(ArrayList record)
        {
            DB.ListPlanScheduleInsert(record);
            table = DB.ListPlanScheduleSelect(user);
            return table;
        }

        //Изменение записи в бд
        public DataTable getListPlanScheduleUpdated(User user, int idSelectedPlanSchedule, ArrayList record)
        {

            DB.ListPlanScheduleUpdate(idSelectedPlanSchedule, record);
            table = DB.ListPlanScheduleSelect(user);
            return table;
        }

        //Таблица с параметрами фильтрации и сортировки
        public DataTable getListPlanScheduleFiltered(string filter, string sort)
        {
            table = DB.ListPlanScheduleFilterSelect(filter, sort);
            return table;
        }

        //Получение списка Нас. пунктов из бд
        public List<string> getListlocality()
        {
            List<string> lst = new List<string>();
            table = DB.ListLocaitySelect();
            for (int i = 0; i < table.Rows.Count; i++)
                lst.Add(table.Rows[i][0].ToString());

            return lst;
        }
    }
}
