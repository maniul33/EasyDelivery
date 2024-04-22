using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDelivery
{
    public class idGenerator
    {
        public string createNewID(List<string> ids, string role)
        {
            Random r = new Random();
            List<int> idsInt = ids.ConvertAll(s => int.Parse(s.Substring(3)));

            int id;
            do
            {
                id = r.Next(100000, 1000000);
            }
            while (idsInt.Contains(id));

            return role + id;
        }
    }
}
