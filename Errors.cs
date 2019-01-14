using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp5
{
    class Errors : Exception
    {
        public int typeOfException;
        public Errors(int message)
        {
            typeOfException = message;
        }
        ~Errors()                //деструктор
        {
        }
        public void Variety()
        {
            Console.WriteLine("You chose wrong variant. Please, choose one of the variety\n");

        }
        public void Number()
        {
            Console.WriteLine("You entered number out of limit\n");

        }
        public void Limit()
        {
            Console.WriteLine("Incorrect entry. Try again: \n");

        }
        public void Empty()
        {
            Console.WriteLine("Store has not materials\n");

        }
        public void Notfound()
        {
            Console.WriteLine("Product not found\n");

        }
        public void Error()
        {
            Console.WriteLine("You entered wrong number of elements. Try again...\n");
        }
        public void Error2()
        {
            Console.WriteLine("Entered wrong values(fo first worker and last in list for qualification)\n");
        }
        public void ErrorQuality()
        {
            Console.WriteLine("Entered wrong value for quality(0<x<10)\n"); Console.Clear();
        }
        public void ErrorDepartment()
        {
            Console.WriteLine("Such a department is not existing\n");
        }
        public void errorState_equipment()
        {
            Console.WriteLine("Wrong value for defining state of equipment\n");
        }
        public void errorList_Depart()
        {
            Console.WriteLine("You entered too big list of elements\n"); Console.WriteLine("Press something to try again..."); Console.ReadLine(); Console.Clear();
        }
        public void error() // вибір типу помилки
        {
            switch (typeOfException)//<  визначити тип помилки
            {
                case 1:
                    {
                        Variety();
                        break;
                    }
                case 2:
                    {
                        Number();
                        break;
                    }
                case 3:
                    {
                        Limit();
                        break;
                    }
                case 4:
                    {
                        Empty();
                        break;
                    }
                case 5:
                    {
                        Notfound();
                        break;
                    }
                case 6:
                    {
                        Error();
                        break;
                    }
                case 7:
                    {
                        Error2();
                        break;
                    }
                     case 8:
                    {
                        ErrorQuality();
                        break;
                    }
                     case 9:
                    {
                        ErrorDepartment();
                        break;
                    }
                     case 10:
                    {
                        errorState_equipment();
                        break;
                    }
                     case 11:
                    {
                        errorList_Depart();
                        break;
                    }
                 
            }
        }
    }
}

