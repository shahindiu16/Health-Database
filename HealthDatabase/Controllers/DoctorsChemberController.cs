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
    public class DoctorsChemberController : ControllerBase
    {
        private readonly IGenericRepository<DoctorsChamber> _repo;

        public DoctorsChemberController(IGenericRepository<DoctorsChamber> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<DoctorsChamber>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<DoctorsChamber>> Post([FromBody] DoctorsChamber value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DoctorsChamber value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            DoctorsChamber d = await _repo.GetTById(id);
            _repo.Delete(d);
            await _repo.SaveAsync(d);
        }
    }
}