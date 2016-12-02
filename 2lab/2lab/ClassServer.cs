using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2lab
{
    public class ClassServer: CollectionBase
    {
        public void Extraction()
        {
            Console.WriteLine("Извлечение из html-кода необходимых данных:");
            
            Thread.Sleep(10);
            this.Save();
        }
        public void Save()
        {
            Console.WriteLine("Фиксация результата");
            Thread.Sleep(7);
            this.Treatment();
        }
        public void Treatment()
        {
            Console.WriteLine("Обработка и формирование результата");

            Thread.Sleep(5);
            this.Vivod();
        }
        public void Vivod()
        {
            Console.WriteLine("Вывод результата в файл или на экран");
            Thread.Sleep(5);
        }
    }
}
