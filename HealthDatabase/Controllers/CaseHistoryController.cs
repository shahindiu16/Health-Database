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
    public class CaseHistoryController : ControllerBase
    {
        private readonly IGenericRepository<CaseHistory> _repo;

        public CaseHistoryController(IGenericRepository<CaseHistory> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<CaseHistory>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<CaseHistory>> Post([FromBody] CaseHistory value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CaseHistory value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(long id)
        {
            CaseHistory c = await _repo.GetTById(id);
            _repo.Delete(c);
            await _repo.SaveAsync(c);
        }
    }
}