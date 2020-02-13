using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderby
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1, 117, 2, 61, 14
            };
            List<int> sortedNumbers = numbers.OrderBy(number => number).ToList();
            foreach (int number in sortedNumbers)
                Console.WriteLine(number);


            DataTable dt = new DataTable();
            dt.Columns.Add("Emp", typeof(string));
            dt.Columns.Add("EID", typeof(int));
            dt.Columns.Add("Dep", typeof(string));

            dt.Rows.Add("Deepu", 11, "Android");
            dt.Rows.Add("Lalu", 10, "SQL Server");
            dt.Rows.Add("Sifvan", 111, "Android");
            dt.Rows.Add("Baburaj", 10, "IT");
            IOrderedEnumerable<DataRow> result;
            result = dt.Select().OrderBy(r => r["eid"]);
            
            foreach (DataRow  x in result )
            {
                Console.WriteLine(x["emp"].ToString() + "," + x["eid"].ToString() + "," + x["Dep"].ToString());
            }







            Console.ReadKey();
        }

    }
}
