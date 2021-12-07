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

        // GET: api/task
        // Bruger en metode ('GetAllTasks()') fra 'TaskRepository' til at retunere en liste over alle opgaver
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationTask>>> GetAll()
        {
            return await _service.GetAllTasks();
        }

        // GET: api/task/5
        // Tager id'et på en bestemt opgave og retunerer alle oplysninger på opgaven
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationTask>> Get(int id)
        {
            var task = await _service.GetTask(id);

            if (task == null)
                return NotFound();

            return task;
        }

        // POST: api/task
        // Laver en ny opgave
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ApplicationTask task)
        {
            await _service.CreateTask(task);

            return Ok();
        }

        // PUT: api/task
        // Tager en opgave som argument og opdateren den eksisterende opgave med en ny
        [HttpPut]
        public async Task Update([FromBody] ApplicationTask task)
        {
            await _service.UpdateTask(task);
        }

        // DELETE: api/task/5
        // Tager et id som argument og fjerner den tilhørende opgave
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
                await _service.DeleteTask(id);

            return Ok();
        }

    }
}
