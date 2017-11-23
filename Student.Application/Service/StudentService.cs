using AutoMapper;
using Student.Application.Dto;
using Student.Application.Interface;
using Student.Core.Entity;
using Student.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application.Service
{
    public class StudentService : IStudentService
    {
        IRepository<StudentInfo> _studentRepository;

        public StudentService(IRepository<StudentInfo> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        /// <summary>
        /// Get one student object by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public StudentInfoDto GetStudent(int Id)
        {
            StudentInfo studentInfo = _studentRepository.GetById(Id);
            StudentInfoDto studentInfoDto = Mapper.Map<StudentInfo, StudentInfoDto>(studentInfo);

            return studentInfoDto;
        }

        /// <summary>
        /// Get student list
        /// </summary>
        /// <returns></returns>
        public List<StudentInfoDto> GetStudents()
        {
            List<StudentInfo> studentInfoList = _studentRepository.GetAll().ToList();
            List<StudentInfoDto> studentInfoDtoList = Mapper.Map<List<StudentInfo>, List<StudentInfoDto>>(studentInfoList);

            return studentInfoDtoList;
        }

        /// <summary>
        /// Create student service
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public async Task CreateStudent(StudentInfoDto student)
        {
            StudentInfo stu = Mapper.Map<StudentInfoDto, StudentInfo>(student);
            await _studentRepository.Create(stu);
        }

        /// <summary>
        /// Update student service
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public async Task UpdateStudent(StudentInfoDto student)
        {
            StudentInfo stu = Mapper.Map<StudentInfoDto, StudentInfo>(student);
            await _studentRepository.Update(student.Id, stu);
        }
    }
}
