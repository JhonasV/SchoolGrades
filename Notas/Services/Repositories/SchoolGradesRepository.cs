using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SchoolGrades.Data;
using SchoolGrades.Framework;
using SchoolGrades.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolGrades.Services.Repositories
{
    public class SchoolGradesRepository : ISchoolGradesRepository
    {
        private readonly SchoolGradesDbContext _context;

        public SchoolGradesRepository(SchoolGradesDbContext context)
        {
            _context = context;
        }
        public async Task<TaskResult<bool>> AddAsync(Models.SchoolGrades schoolGrades)
        {
            var result = new TaskResult<bool>();
            await _context.SchoolGrades.AddAsync(schoolGrades);
            result.Data = await _context.SaveChangesAsync() > 0;
            return result;
        }

        public async Task<TaskResult<bool>> DeleteAsync(int id)
        {
            var result = new TaskResult<bool>();
            _context.SchoolGrades.Remove(new Models.SchoolGrades { Id = id });
            result.Data = await _context.SaveChangesAsync() > 0;
            return result;
        }

        public async Task<TaskResult<List<Models.SchoolGrades>>> GetByStudentIdAsync(string studentId)
        {
            var result = new TaskResult<List<Models.SchoolGrades>>();
            result.Data = await _context
                .SchoolGrades
                .Where(s => s.StudentId == studentId)
                .ToListAsync();

            return result;
        }

        public async Task<TaskResult<List<Models.SchoolGrades>>> GetAllAsync()
        {
            var result = new TaskResult<List<Models.SchoolGrades>>();
            result.Data = await _context
                .SchoolGrades         
                .ToListAsync();

            return result;
        }

        public async Task<TaskResult<bool>> UpdateAsync(int id, Models.SchoolGrades schoolGrades)
        {
            throw new NotImplementedException();
        }

    }
}
