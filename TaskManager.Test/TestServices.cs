using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TaskManager.API;
using System.Web.Mvc;
using System.Collections;
using System.Web;
using System.Web.Http;
using TaskManager.BusinessLib;
using System.Web.Http.Results;

namespace Test
{
    [TestFixture]
    class TestServices
    {

        [Test]
        public void TaskControllerGetTasksByIdTest2()
        {
            var controller = new TaskController();
            var result = controller.GetTasksById(1) as OkNegotiatedContentResult<TaskManager.Entities.Task>;
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Content.TaskId);

        }

 


    [Test]
    public void TaskTestCreateAction()

    {
        Random randm = new Random();
        int rand = randm.Next(1, 1000);

        string TaskName1 = "Test2" + rand.ToString();
        TaskController controller = new TaskController();
               TaskManager.Entities.Task task = new TaskManager.Entities.Task();
        task.Priority = 10;
        task.TaskName = TaskName1;
        task.Startdate = DateTime.Now;
       
        var CreateResult = controller.Post(task) as OkNegotiatedContentResult<string>;
        Assert.AreEqual("Task Added Sucessfully", CreateResult.Content);
            

    }

    [Test]
    public void TaskTestEditAction()
    {
            var controller = new TaskController();
            var result = controller.GetTasksById(1) as OkNegotiatedContentResult<TaskManager.Entities.Task>;
            Assert.IsNotNull(result);
          
            TaskManager.Entities.Task task = (TaskManager.Entities.Task)result.Content;
            var CreateResult = controller.Put(task) as  OkNegotiatedContentResult<string>;
            Assert.AreEqual("Task Updated Sucessfully", CreateResult.Content);
           


        }
    }
}