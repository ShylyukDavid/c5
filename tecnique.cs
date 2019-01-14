// File:    tecnique.cs
// Author:  David
// Created: вторник, 13 ноября 2018 г. 07:58:30
// Purpose: Definition of Class tecnique

using c_sharp5;
using System;

public class tecnique:Worker
{
   
   public void fix_problem(int i,int j)
   {
       Console.WriteLine("Department#{0}: conveyer line{1} repaired succesfully\n",i,j);
   }

    public static bool operator <(tecnique obj1, tecnique obj2)
    {
        if (obj1.worked_years < obj2.worked_years)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator >(tecnique obj1, tecnique obj2)
    {
        if (obj1.worked_years > obj2.worked_years)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public tecnique()      //конструктор за замовчуванням
    {
        new Worker();
        Console.WriteLine("The tecnique was created by default");
    }
    public tecnique(int s)      //конструктор ініціалізації
    {
        new Worker(s, 2);
        Console.WriteLine("The tecnique was created by initialisation");
    }
    public tecnique(tecnique arg)                //конструктор копіювання
    {
        worked_years = arg.worked_years;
        qualification = arg.qualification;
        Console.WriteLine("The tecnique was created by copy");
    }
    ~tecnique()                //деструктор
    {
        Console.WriteLine("The tecnique was destructed");
    }

   
   public void hold_sems()
   {
      throw new NotImplementedException();
   }
   
   public void repair_equip()
   {
      throw new NotImplementedException();
   }
   
   public void equip_lines_for_prototype()
   {
      throw new NotImplementedException();
   }
   
   public void check_equip()
   {
      throw new NotImplementedException();
   }

}