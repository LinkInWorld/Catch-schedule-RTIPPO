using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class MunicipalContract
    {
        int id;
        int number;
        string dateOfConclusion;
        string dateOfExecotion;
        int customer;
        int executor;

        public MunicipalContract(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                id = int.Parse(row[0].ToString());
                number = int.Parse(row[1].ToString());
                dateOfConclusion = (row[2].ToString());
                dateOfExecotion = (row[3].ToString());
                customer = int.Parse(row[4].ToString());
                executor = int.Parse(row[5].ToString());
            }

        }

    }
}
