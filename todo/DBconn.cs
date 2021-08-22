using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace todo
{
    public class DBconn
    {
        public static List<TodoData> fetchedData = new List<TodoData>();
        
        public static List<TodoData> getData() {
            return fetchedData;
        }

        public static void insertData(TodoData newData) {
            fetchedData.Add(newData);
        }
    }
}
