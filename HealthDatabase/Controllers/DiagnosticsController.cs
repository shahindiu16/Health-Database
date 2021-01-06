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
    public class DiagnosticsController : ControllerBase
    {
        private readonly IGenericRepository<Diagnostics> _repo;

        public DiagnosticsController(IGenericRepository<Diagnostics> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Diagnostics>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<Diagnostics>> Post([FromBody] Diagnostics value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Diagnostics value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Diagnostics d = await _repo.GetTById(id);
            _repo.Delete(d);
            await _repo.SaveAsync(d);
        }
    }
}