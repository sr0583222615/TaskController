using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using System.Xml.Linq;
using System;

namespace TaskController
{
    public class TaskService : ItaskService
    {



        private readonly ILogger<TaskService> _logger;

        public TaskService(ILogger<TaskService> logger)
        {
            _logger = logger;
        }

        public List<Task1> listTask = new List<Task1>();
        Task1 t1 = new Task1() { Title = "java", Description = "good lang", Duedate = "yanuar", Level = Priority.Important };
        Task1 t2 = new Task1() { Title = "hm", Description = "good doing", Duedate = "tomarow", Level = Priority.negligible };
        Task1 t3 = new Task1() { Title = "do schedule", Description = "nice lang", Duedate = "october", Level = Priority.critical };

        public string addTask(Task1 t)
        {
            listTask.Add(t);
            return t.Title;
        }
        public void OnGet()
        {
            _logger.LogInformation("info");
        }

        public List<Task1> GetTasks()
        {
            throw new NotImplementedException();

        }

        public void removeTask(Task1 t)
        {
            listTask.Remove(t);


        }

        public Task1 update(Task1 t1 ,string title)
        {

        int TaskIndex = listTask.FindIndex(e => e.Title == title);
            if( TaskIndex != -1)
            listTask[TaskIndex] = t1; 
            return t1;
        }

       public List<Task1> getAll()
        {
            return listTask;
        }

    }

}
 

  

