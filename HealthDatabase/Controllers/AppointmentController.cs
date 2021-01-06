using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthDatabase.Models;
using HealthDatabase.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IGenericRepository<Appointment> _repo;

        public AppointmentController(IGenericRepository<Appointment> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Appointment>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<Appointment>> Post([FromBody] Appointment value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Appointment value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(long id)
        {
            Appointment a = await _repo.GetTById(id);
            _repo.Delete(a);
            await _repo.SaveAsync(a);
        }
    }
}