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
    class Program
    {
        const int MaxCountPC = 2;
        const int MaxCountTrans = 10;

        ClassServer serv = new ClassServer();

        static int rs = 0;
        static void Main(string[] args)
        {
            Program p = new Program();

            //потоки
            for (int i = 0; i < MaxCountPC; i++)
            {
                Thread myThread = new Thread(p.pars);
                myThread.Start();

            }

            Console.ReadLine();

            Console.Read();
        }

        void pars()
        {
            for (int i = 0; i < MaxCountTrans; i++)
            {
            ClassServer serv = new ClassServer();
            ClassPC cl = new ClassPC();
            Console.WriteLine("Клиент " + "отправляет данные на сервер");
            cl.load(serv);
        }
        }

    } 
}



