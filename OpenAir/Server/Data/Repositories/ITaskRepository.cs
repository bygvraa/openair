using OpenAir.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace OpenAir.Server.DataAccess.Repositories
{
    public interface ITaskRepository
    {
        Task<List<TaskClass>> GetAllTasks();
        Task<TaskClass> GetTask(int task_id);
        Task CreateTask(TaskClass task);
        Task UpdateTask(TaskClass task);
        Task DeleteTask(int task_id);
    }
}