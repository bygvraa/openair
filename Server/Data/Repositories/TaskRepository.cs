using OpenAir.Shared.Models;
using OpenAir.Server.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace OpenAir.Server.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _dBContext;

        public TaskRepository(ApplicationDbContext dBContext)
        {
            _dBContext = dBContext;
        }


        // Task -----------------------------------------

        // GET    - find alle opgaver
        public async Task<List<ApplicationTask>> GetAllTasks()
        {
            return await _dBContext.task.ToListAsync();
        }
        
        // GET    - find specifik opgaver
        public async Task<ApplicationTask> GetTask(int id)
        {
            return await _dBContext.task.FindAsync(id);
        }

        // POST   - lav en opgave
        public async Task CreateTask(ApplicationTask task)
        {
            await _dBContext.task.AddAsync(task);
            await _dBContext.SaveChangesAsync();
        }

        // PUT    - opdater en opgave
        public async Task UpdateTask(ApplicationTask task)
        {
            _dBContext.task.Update(task);
            await _dBContext.SaveChangesAsync();
        }

        // DELETE - fjern en opgave
        public async Task DeleteTask(int id)
        {
            var taskToDelete = await _dBContext.task.FindAsync(id);
            
            if (taskToDelete == null)
                throw new NullReferenceException();
        
            _dBContext.task.Remove(taskToDelete);
                await _dBContext.SaveChangesAsync();
         }

        // -------------------------------------------------

        public async Task<List<ApplicationTask>> GetAllTasksCategory(string category)
        {
            var tasksCategory = _dBContext.task
                .Where(c => c.Category == category)
                .ToListAsync();

            return await tasksCategory;
        }


        public async Task UpdateTaskBooking(ApplicationTask task)
        {
            _dBContext.task.Update(task);
            await _dBContext.SaveChangesAsync();
        }


        // -------------------------------------------------
    }
}