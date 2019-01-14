using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp5
{
    public class Worker
    {
        public int worked_years;
        public int qualification;

        public Worker()
        {
            worked_years = 0; qualification = 4;
          //  Console.WriteLine("The worker was created by default");
        }

        public Worker(int s, int k)      //конструктор ініціалізації
        {
            worked_years = s; qualification = k;
            //Console.WriteLine("The worker was created by initialisation");
        }
        public Worker(Worker arg)                //конструктор копіювання
        {
            worked_years = arg.worked_years; qualification = arg.qualification;
           // Console.WriteLine("The worker was created by copy");
        }
        ~Worker()                //деструктор
        {
            Console.WriteLine("The worker was destructed");
        }

        public int Worked_years
        {
            get { return worked_years; }
            set { worked_years = value; }
        }
        public int Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }
        public virtual void qualify()
        {
            Console.WriteLine("Virtual function in Worker!");
        }
    }
}
