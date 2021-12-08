//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using OpenAir.Shared.Models;
//using OpenAir.Server.Data.Repositories;
//using Microsoft.EntityFrameworkCore;

//namespace OpenAir.Server.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class BilletController : ControllerBase
//    {
//        private readonly IBilletRepository _service;

//        public BilletController(IBilletRepository service)
//        {
//            _service = service;
//        }
//        // GET: /<controller>/

//        // GET: api/task
//        // Bruger en metode ('GetAllTasks()') fra 'TaskRepository' til at retunere en liste over alle opgaver
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<TaskClass>>> GetAll()
//        {
//            return await _service.GetAllBilletter();
//        }


//        [HttpGet("{billet_id}")]
//        public async Billet<ActionResult<BilletClass>> Get(int billet_id)
//        {
//            var billet = await _service.GetBillet(billet_id);

//            if (billet == null)
//                return NotFound();

//            return billet;
//        }
//    }
//}
