using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StaffAffairs.BusinessLogic.Services;
using StaffAffairs.DataLayer.DBContext;
using StaffAffairs.DataLayer.Models;

namespace StaffAffairs.AWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptsController : ControllerBase
    {
        private readonly IService<Dept> _deptService;

        public DeptsController(IService<Dept> deptService)
        {
            _deptService = deptService;
        }

        // GET: api/Depts
        [HttpGet]
        public IActionResult GetDepts()
        {
            var depts =  _deptService.GetAll().ToList();
            if(depts == null)
            {
                return NotFound();
            }
            return Ok(depts);
        }

        // GET: api/Depts/5
        [HttpGet("{id}")]
        public IActionResult GetDept(int id)
        {
            var dept = _deptService.GetById(id);

            if (dept == null)
            {
                return NotFound();
            }

            return Ok(dept);
        }

        // PUT: api/Depts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDept(int id, Dept dept)
        {
            if (id != dept.Id)
            {
                return BadRequest();
            }
           
            try
            {
                _deptService.Update(dept);
                _deptService.save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeptExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Depts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult AddDept(Dept dept)
        {
            
            try
            {
                _deptService.Add(dept);
                _deptService.save();

            }
            catch (DbUpdateException)
            {
                if (DeptExists(dept.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDept", new { id = dept.Id }, dept);
        }

        // DELETE: api/Depts/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDept(int id)
        {
            var dept = _deptService.GetById(id);
            if (dept == null)
            {
                return NotFound();
            }

            _deptService.Delete(id);
            _deptService.save();

            return NoContent();
        }
        
        
        private bool DeptExists(int id)
        {
            return _deptService.GetById(id) != null;
        }
    }
}
