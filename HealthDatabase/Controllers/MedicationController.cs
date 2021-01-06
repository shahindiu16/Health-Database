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
    public class MedicationController : ControllerBase
    {
        private readonly IGenericRepository<Medication> _repo;

        public MedicationController(IGenericRepository<Medication> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Medication>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<Medication>> Post([FromBody] Medication value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Medication value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(long id)
        {
            Medication m = await _repo.GetTById(id);
            _repo.Delete(m);
            await _repo.SaveAsync(m);
        }
    }
}