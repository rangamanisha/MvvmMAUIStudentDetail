using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteDemo.Model;
using SQLiteDemo.ViewModels;

namespace SQLiteDemo.Services
{
    public interface IStudentService
    {
        Task<List<StudentModel>> GetStudentList();

        Task<int> AddStudent(StudentModel studentModel);

        Task<int> DeleteStudent(StudentModel student);

        Task<int> UpdateStudent(StudentModel student);
    }
}
