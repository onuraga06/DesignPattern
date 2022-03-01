using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    public class TableServer
    {
        //yapılan uygualamda bir siniftan saddece bir nesne olusturmak istiyorsak kullanılır. Singletone sayayesınde ıkıncı bir nesne olusturulamaz
        private static readonly TableServer _instance = new TableServer();
        private List<string> servers = new List<string>();
        
        private int nextserver = 0;
        public TableServer()
        {
            servers.Add("Onur");
            servers.Add("Faruk");
            servers.Add("Orkun");
            servers.Add("Kadir");
            servers.Add("Oğuz");
        }
        public string GetNextServer()
        {
            
            string output = servers[nextserver];
            nextserver++;
            if (nextserver>= servers.Count() )
            {
                nextserver = 0;
            }
            return output;
        }
        public static TableServer GetTableServer()
        {
            return _instance;
        }

    }
}
