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
    public class DiseaseController : ControllerBase
    {
        private readonly IGenericRepository<Disease> _repo;

        public DiseaseController(IGenericRepository<Disease> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Disease>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<Disease>> Post([FromBody] Disease value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Disease value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Disease d = await _repo.GetTById(id);
            _repo.Delete(d);
            await _repo.SaveAsync(d);
        }
    }
}