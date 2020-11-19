using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SchoolGrades.Framework;
using SchoolGrades.Framework.Extensions;
using SchoolGrades.Services.Interfaces;

namespace SchoolGrades.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class SchoolGradesController : ControllerBase
    {
        private readonly ISchoolGradesRepository _schoolGradesRepository;

        public SchoolGradesController(ISchoolGradesRepository schoolGradesRepository)
        {
            _schoolGradesRepository = schoolGradesRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get([Required]string studentId)
        {
    
            var result = await _schoolGradesRepository.GetByStudentIdAsync(studentId);

            if (result.Success)
                result.AddMessage("Lista de notas recuperadas correctamente.");

            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var result = await _schoolGradesRepository.GetAllAsync();

            if (result.Success)
                result.AddMessage("Lista de notas recuperadas correctamente.");

            return Ok(result);
        }

        // POST: api/SchoolGrades
        [HttpPost]
        public async Task<IActionResult> Save(Models.SchoolGrades schoolGrades)
        {
            var result = await _schoolGradesRepository.AddAsync(schoolGrades);

            if (result.Success)
                result.AddMessage("El recurso se creó correctamente.");

            return Ok(result);
        }

        // PUT: api/SchoolGrades/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
