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
    public class SurgeryController : ControllerBase
    {
        private readonly IGenericRepository<Surgery> _repo;

        public SurgeryController(IGenericRepository<Surgery> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Surgery>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<Surgery>> Post([FromBody] Surgery value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Surgery value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Surgery s = await _repo.GetTById(id);
            _repo.Delete(s);
            await _repo.SaveAsync(s);
        }
    }
}