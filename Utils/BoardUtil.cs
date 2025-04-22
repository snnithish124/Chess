using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Utils
{
    public static class BoardUtil
    {
        public static void print(this Object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            Console.WriteLine(json);
        }
    }
}
