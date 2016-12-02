using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace _2lab
{
    class ClassPC
    {
       
        public void load (ClassServer server)
         {
            Thread.Sleep(100);
            Console.WriteLine("Загрузка файла на сервер");
            server.Extraction();
         }
        
    }
}
