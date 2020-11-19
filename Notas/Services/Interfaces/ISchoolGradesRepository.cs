using SchoolGrades.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolGrades.Services.Interfaces
{
    public interface ISchoolGradesRepository
    {
        Task<TaskResult<bool>> AddAsync(Models.SchoolGrades schoolGrades); 
        Task<TaskResult<List<Models.SchoolGrades>>> GetByStudentIdAsync(string studentId);
        Task<TaskResult<List<Models.SchoolGrades>>> GetAllAsync();
        Task<TaskResult<bool>> DeleteAsync(int id); 
        Task<TaskResult<bool>> UpdateAsync(int id, Models.SchoolGrades schoolGrades); 
    }
}
