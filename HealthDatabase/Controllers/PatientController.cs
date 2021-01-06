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
    public class PatientController : ControllerBase
    {
        private readonly IGenericRepository<Patient> _repo;
        //private readonly IGenericRepository<Doctor> _doctorrepo;
        //private readonly IGenericRepository<Hospital> _hospitalrepo;
        //private readonly IGenericRepository<Prescription> _Prescriptionrepo;
        //private readonly IGenericRepository<CaseHistory> _CaseHistoryrepo;


        //public PatientController(IGenericRepository<Patient> repo)
        //{
        //    _repo = repo;
        //}
        public PatientController(IGenericRepository<Patient> repo, IGenericRepository<Doctor> doctorrepo, IGenericRepository<Hospital> hospitalrepo, IGenericRepository<Prescription> Prescriptionrepo, IGenericRepository<CaseHistory> CaseHistoryrepo)
        {
            _repo = repo;
            //_doctorrepo = doctorrepo;
            //_hospitalrepo = hospitalrepo;
            //_Prescriptionrepo = Prescriptionrepo;
            //_CaseHistoryrepo= CaseHistoryrepo;
        }

        [HttpPost]
        public async Task<ActionResult<Patient>> Post([FromBody] Patient value)
        {
            _repo.Add(value);
            await _repo.SaveAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient value)
        {
            _repo.Update(value);
        }
        [HttpDelete("{id}")]
        public async Task Delete(long id)
        {
            Patient p = await _repo.GetTById(id);
            _repo.Delete(p);
            await _repo.SaveAsync(p);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var patient = await _repo.GetTById(id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }



    }
}