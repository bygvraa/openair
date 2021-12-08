//using OpenAir.Shared.Models;
//using OpenAir.Server.Data;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using System;

//namespace OpenAir.Server.Data.Repositories
//{
//    public class BilletRepository : IBilletRepository
//    {
//        private readonly ApplicationDbContext _dBContext;

//        public BilletRepository(ApplicationDbContext dBContext)
//        {
//            _dBContext = dBContext;
//        }


//        // Task -----------------------------------------

//        // GET    - find alle opgaver
//        public async Billet<List<BilletClass>> GetAllBilletter()
//        {
//            return await _dBContext.task.ToListAsync();
//        }

//        // GET    - find specifik opgaver
//        public async Task<TaskClass> GetTask(int task_id)
//        {

//            return await _dBContext.task.FindAsync(task_id);
//        }

//        // POST   - lav en opgave
//        public async Task CreateTask(TaskClass task)
//        {
//            await _dBContext.task.AddAsync(task);
//            await _dBContext.SaveChangesAsync();
//        }

//        // PUT    - opdater en opgave
//        public async Task UpdateTask(TaskClass task)
//        {
//            _dBContext.task.Update(task);
//            await _dBContext.SaveChangesAsync();
//        }

//        // DELETE - fjern en opgave
//        public async Task DeleteTask(int task_id)
//        {
//            var taskToDelete = await _dBContext.task.FindAsync(task_id);

//            if (taskToDelete == null)
//                throw new NullReferenceException();

//            _dBContext.task.Remove(taskToDelete);
//            await _dBContext.SaveChangesAsync();
//        }

//        // -------------------------------------------------
//    }
//}
