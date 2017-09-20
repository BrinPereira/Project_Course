using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IBusinessLayer
    {
        IList<Standard> getAllStandards();

        Standard GetStandardByID(int id);

        void addStandard(Standard Standard);

        void updateStandard(Standard Standard);

        void removeStandard(Standard Standard);

        IList<Student> getAllStudents();

        Student GetStudentByID(int id);

        void addStudent(Student Student);

        void UpdateStudent(Student Student);

        void RemoveStudent(Student Student);

         Standard GetStandardByIDWithStudents(int id);

    }
}
