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
    public class AuthorityController : ControllerBase
    {
        private readonly IGenericRepository<Authority> _repo;

        public AuthorityController(IGenericRepository<Authority> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Authority>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<Authority>> Post([FromBody] Authority value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Authority value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Authority a = await _repo.GetTById(id);
            _repo.Delete(a);
            await _repo.SaveAsync(a);
        }
    }
}