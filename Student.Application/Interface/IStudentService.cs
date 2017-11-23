using Student.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application.Interface
{
    /// <summary>
    /// Student service interface
    /// </summary>
    public interface IStudentService
    {
        StudentInfoDto GetStudent(int Id);
        List<StudentInfoDto> GetStudents();
        Task CreateStudent(StudentInfoDto student);
        Task UpdateStudent(int Id, StudentInfoDto student);
    }
}
