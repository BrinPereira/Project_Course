using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class BusinessLayer : IBusinessLayer
    {

        private readonly IStandardRepository _standardRepository;
        private readonly IStudentRepository _studentRepository;
        

        public BusinessLayer()
        {
            _standardRepository = new StandardRepository();
            _studentRepository = new StudentRepository();
        }

        public void addStandard(Standard Standard)
        {
            _standardRepository.Insert(Standard);
        }

        public void addStudent(Student Student)
        {
            _studentRepository.Insert(Student);
        }

        public IList<Standard> getAllStandards()
        {
            return _standardRepository.GetAll().ToList();
        }

        public IList<Student> getAllStudents()
        {
            return _studentRepository.GetAll().ToList();
        }

        public Standard GetStandardByID(int id)
        {
            return _standardRepository.GetSingle(
                 s => s.StandardId == id,
                 s => s.Students);
        }

        public Student GetStudentByID(int id)
        {
            //    return _studentRepository.GetSingle(
            //        s => s.StudentID== id,
            //        s => s.StudentID);

            return _studentRepository.GetById(id);
        }

        public void removeStandard(Standard Standard)
        {
            _standardRepository.Delete(Standard);
        }

        public void RemoveStudent(Student Student)
        {
            _studentRepository.Delete(Student);
        }

        public void updateStandard(Standard Standard)
        {
            _standardRepository.Update(Standard);
        }

        public void UpdateStudent(Student Student)
        {
            _studentRepository.Update(Student);
        }

        public Standard GetStandardByIDWithStudents(int id)
        {
            return _standardRepository.GetSingle(
                s => s.StandardId == id,
                s => s.Students);
        }


    }
}
