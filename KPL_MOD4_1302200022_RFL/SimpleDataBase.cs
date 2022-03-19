using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_MOD4_1302200022_RFL
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDate;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDate = new List<DateTime>();
        }

        public void AddNewData(T databaru)
        {
            storedData.Add(databaru);
            inputDate.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            foreach(T databaru in storedData)
            {
                Console.WriteLine("Data: " + databaru.ToString() + " yang disimpan pada waktu " + DateTime.Now); 
            }
        }

    }
}
