﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenAir.Server.Data.Repositories;
using OpenAir.Shared.Models;
using Microsoft.AspNetCore.Authorization;

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


        // Bruger en metode ('GetAllTasks()') fra 'TaskRepository' til at retunere en liste over alle opgaver
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationTask>>> GetAll()
        {
            return await _service.GetAllTasks();
        }


        // Tager id'et på en bestemt opgave og retunerer alle oplysninger på opgaven
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationTask>> Get(int id)
        {
            var task = await _service.GetTask(id);

            if (task == null)
                return NotFound();

            return task;
        }


        // Laver en ny opgave
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ApplicationTask task)
        {
            await _service.CreateTask(task);

            return Ok();
        }


        // Tager en opgave som argument og opdaterer den eksisterende opgave med en ny
        [HttpPut]
        public async Task Update([FromBody] ApplicationTask task)
        {
            await _service.UpdateTask(task);
        }


        // Tager et id som argument og fjerner den tilhørende opgave
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
                await _service.DeleteTask(id);

            return Ok();
        }

        // -------------------------------------------------

        // Tager en kategori som argument, og retunerer alle tasks med denne kategori
        [HttpGet("Category/{category}")]
        public async Task<ActionResult<IEnumerable<ApplicationTask>>> GetTasksInCategory(string category)
        {
            return await _service.GetAllTasksCategory(category);
        }


        // Opdater booking-status på en task (en frivillig kan tilføje eller fjerne sig fra en task)
        [Authorize(Roles = "Administrator, Kontaktperson, Frivillig")]
        [HttpPut("UpdateBooking")]
        public async Task Book([FromBody] ApplicationTask task)
        {
            await _service.UpdateTask(task);
        }
    }
}
