using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Microsoft.VisualBasic;

namespace TaskController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {


       



        private readonly ItaskService taskService;

        [HttpPost("add")]
        public string createTask([FromBody] Task1 t1)
        {
            return taskService.addTask(t1);
        }

        [HttpDelete("delet")]
        public string remove([FromBody] Task1 t)
        {
            taskService.removeTask(t);
            return t.Title;
        }
        [HttpPut("update")]
        public void put([FromBody] Task1 t, string x)
        {
            taskService.update(t, x);
        }
        [HttpGet]
        public List<Task1> Get()
        {
            return taskService.getAll();
        }
    }

}
