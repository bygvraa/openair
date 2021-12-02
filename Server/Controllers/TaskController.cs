using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAir.Shared.Models;
using OpenAir.Server.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace OpenAir.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _service;

        public TaskController(ITaskRepository service)
        {
            _service = service;
        }

        // GET: api/user
        // Bruger en metode ('GetAllTasks()') fra 'TaskRepository' til at retunere en liste over alle opgaver
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskClass>>> GetAll()
        {
            return await _service.GetAllTasks();
        }

        // GET: api/user/5
        // Tager id'et på en bestemt opgave og retunerer alle oplysninger på opgaven
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskClass>> Get(int task_id)
        {
            var task = await _service.GetTask(task_id);

            if (task == null)
                return NotFound();

            return task;
        }

        // POST: api/user
        // Laver en ny opgave med et unikt id (guid)
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] TaskClass task)
        {
            await _service.CreateTask(task);

            return Ok();
        }

        // PUT: api/user
        // Tager en opgave som argument og retunerer alle opgave oplysninger
        [HttpPut]
        public async Task<ActionResult<TaskClass>> Update([FromBody] TaskClass task)
        {
            if (ModelState.IsValid)
                await _service.UpdateTask(task);

            return task;
        }

        // DELETE: api/user/5
        // Tager et id som argument og fjerner den tilhørende opgave
        [HttpDelete("{task_id}")]
        public async Task<ActionResult> Delete(int task_id)
        {
            if (ModelState.IsValid)
                await _service.DeleteTask(task_id);

            return Ok();
        }

    }
}
