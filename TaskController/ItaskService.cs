using Microsoft.OpenApi.Any;

namespace TaskController
{
    public interface ItaskService
    {
       List<Task1> GetTasks();
       string addTask( Task1 t);
        void removeTask( Task1 t);
        Task1 update(Task1 t ,string title);
        List<Task1> getAll();


    }
}
