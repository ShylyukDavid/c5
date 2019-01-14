// File:    hand_worker.cs
// Author:  David
// Created: вторник, 13 ноября 2018 г. 07:23:33
// Purpose: Definition of Class hand_worker

using c_sharp5;
using System;

public class hand_worker:Worker
{
    private int num_pos { get; set; }
    public int Num_pos
    {
        get { return num_pos; }
        set { num_pos = value; }
    }

    public hand_worker()      //конструктор за замовчуванням
    {
        new Worker();
        num_pos = 1; 
       // Console.WriteLine("The hand_worker was created by default");
    }
    public hand_worker(int num, int qual)      //конструктор ініціалізації
    {
        new Worker(2, qual);
        num_pos = num;
      //  Console.WriteLine("The hand_worker was created by initialisation");
    }
    public hand_worker(hand_worker arg)                //конструктор копіювання
    {
        num_pos = arg.num_pos;
        qualification = arg.qualification;
        worked_years = arg.worked_years;
        Console.WriteLine("The hand_worker was created by copy");
    }
    ~hand_worker()                //деструктор
    {
        Console.WriteLine("The hand_worker was destructed");
    }
    public static hand_worker operator ++(hand_worker c1)
    {
        return new hand_worker { Qualification = c1.Qualification + 10 };
    }

    public void signal_stop()
   {
      throw new NotImplementedException();
   }
   
   public void visit_sems()
   {
      throw new NotImplementedException();
   }

}