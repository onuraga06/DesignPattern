using System;

namespace SingleTone
{
    class Program
    {
        static TableServer host1list = TableServer.GetTableServer(); /*new TableServer();*/
        static TableServer host2list = TableServer.GetTableServer(); /*new TableServer();*/
        static void Main(string[] args)
        {

            TableServer tbl = TableServer.GetTableServer(); //new TableServer();
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("nextServer is="+tbl.GetNextServer());
                HostListNextServer();
                Host2ListNextServer();
            }
            Console.ReadLine();
        }
        private static void HostListNextServer()
        {
            Console.WriteLine("The next=" +host1list.GetNextServer());
        }
        private static void Host2ListNextServer()
        {
            Console.WriteLine("The next=" + host2list.GetNextServer());
        }

    }
}
