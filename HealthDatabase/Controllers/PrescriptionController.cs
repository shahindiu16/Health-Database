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
    public class PrescriptionController : ControllerBase
    {
        private readonly IGenericRepository<Prescription> _repo;

        public PrescriptionController(IGenericRepository<Prescription> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Prescription>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<Prescription>> Post([FromBody] Prescription value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Prescription value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Prescription p = await _repo.GetTById(id);
            _repo.Delete(p);
            await _repo.SaveAsync(p);
        }
    }
}