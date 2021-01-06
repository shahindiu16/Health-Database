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
    public class DiagnosisController : ControllerBase
    {
        private readonly IGenericRepository<Diagnosis> _repo;

        public DiagnosisController(IGenericRepository<Diagnosis> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Diagnosis>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<Diagnosis>> Post([FromBody] Diagnosis value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Diagnosis value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(long id)
        {
            Diagnosis d = await _repo.GetTById(id);
            _repo.Delete(d);
            await _repo.SaveAsync(d);
        }
    }
}