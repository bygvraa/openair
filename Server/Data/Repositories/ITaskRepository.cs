using OpenAir.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace OpenAir.Server.Data.Repositories
{
    public interface ITaskRepository
    {
        Task<List<ApplicationTask>> GetAllTasks();
        Task<ApplicationTask> GetTask(int id);
        Task CreateTask(ApplicationTask task);
        Task UpdateTask(ApplicationTask task);
        Task DeleteTask(int id);

        Task<List<ApplicationTask>> GetAllTasksCategory(string category);

        Task UpdateTaskBooking(ApplicationTask task);
    }
}