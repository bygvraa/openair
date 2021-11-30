using OpenAir.Shared.Models;
using OpenAir.Server.DataAccess.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace OpenAir.Server.DataAccess.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DomainDbContext _dBContext;

        public TaskRepository(DomainDbContext dBContext)
        {
            _dBContext = dBContext;
        }


        // Task -----------------------------------------

        // GET    - find alle opgaver
        public async Task<List<TaskClass>> GetAllTasks()
        {
            return await _dBContext.task.ToListAsync();
        }
        
        // GET    - find specifik opgaver
        public async Task<TaskClass> GetTask(int task_id)
        {
            
            return await _dBContext.task.FindAsync(task_id);
        }

        // POST   - lav en opgave
        public async Task CreateTask(TaskClass task)
        {
            await _dBContext.task.AddAsync(task);
          await _dBContext.SaveChangesAsync();
        }

        // PUT    - opdater en opgave
        public async Task UpdateTask(TaskClass task)
        {
            var taskToUpdate = await _dBContext.task.FindAsync(task.task_id);

            if (taskToUpdate == null)
                throw new NullReferenceException();

            _dBContext.task.Update(task);
            await _dBContext.SaveChangesAsync();
        }

        // DELETE - fjern en opgave
        public async Task DeleteTask(int task_id)
        {
            var taskToDelete = await _dBContext.task.FindAsync(task_id);

            if (taskToDelete == null)
          throw new NullReferenceException();
        
         _dBContext.task.Remove(taskToDelete);
           await _dBContext.SaveChangesAsync();
         }

        // -------------------------------------------------
    }
}