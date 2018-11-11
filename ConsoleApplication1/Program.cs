using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TaskManager.BusinessLib;
using TaskManager.Entities;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                TaskBL obj = new TaskBL();
                Task t = obj.GetTaskById(2);
                t.TaskName = "new task";
                obj.UpdateTask(t);
               
                List<Task> ts=obj.GetAllTasks();
             /*   foreach ( Task t in ts)
                    {
                    Console.WriteLine("amount is {0}, and type is {1}", t.TaskId, t.TaskName); 
                }*/
               
                  obj.AddTask(new TaskManager.Entities.Task()
                  {
                      TaskId = 2,
                      TaskName = "Testdfgdgdg2",
                      Startdate = DateTime.Now,
                      Enddate = DateTime.Now,
                      Priority = 10

                  }
                );

                /*
                 obj.AddTask(new TaskManager.Entities.Task()
                 {
                     TaskId = 3,
                     TaskName = "Test3",
                     Startdate = DateTime.Now,
                     Enddate = DateTime.Now,
                     Priority = 10,

                     TaskParentId = 2

                 }
               );*/


            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
         

        }
    }
}
