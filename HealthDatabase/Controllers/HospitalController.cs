﻿using System;
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
    public class HospitalController : ControllerBase
    {
        private readonly IGenericRepository<Hospital> _repo;

        public HospitalController(IGenericRepository<Hospital> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Hospital>> Get()
        {
            return await _repo.GetT();
        }
        [HttpPost]
        public async Task<ActionResult<Hospital>> Post([FromBody] Hospital value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Hospital value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            Hospital h = await _repo.GetTById(id);
            _repo.Delete(h);
            await _repo.SaveAsync(h);
        }
    }
}