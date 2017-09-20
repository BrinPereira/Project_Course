using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client6
{
    class Program
    {
        static void Main(string[] args)
        {
            int again = 0;
            do
            {
                Console.WriteLine("Select Option \n\r");
                Console.WriteLine("1) Add new Standard \n\r2) Update Standard \n\r3) Delete Standard \n\r4) Search Standard  \n\r" +
                                  "5) Display Students related to Standard \n\r6) Display all Standards \n\r7) Add new Student \n\r" +
                                  "8) Update Student \n\r9) Delete Student \n\r10) Search Student \n\r11) Display all Students \n\r" +
                                    "12) Exit the program \n\r ");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                BusinessLayer.BusinessLayer b = new BusinessLayer.BusinessLayer();
                Standard sobj = new Standard();
                Student stuobj = new Student();
                IList<Standard> d;
                IList<Student> studs;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter standard");
                        sobj.StandardId = Convert.ToInt32(Console.ReadLine());
                        sobj.StandardName = Console.ReadLine();
                        b.addStandard(sobj);
                        Console.WriteLine("Standard added \n\r Existing Standards:");
                        d = b.getAllStandards();
                        foreach (Standard obj in d)
                        Console.WriteLine(string.Format("{0} - {1}", obj.StandardId, obj.StandardName));
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Enter standard ID to update");
                        sobj.StandardId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter standard name to update");
                        sobj.StandardName = Console.ReadLine();
                        b.updateStandard(sobj);
                        Console.WriteLine("Standard update \n\r Existing Standards:");
                        d = b.getAllStandards();
                        foreach (Standard obj in d)
                        Console.WriteLine(string.Format("{0} - {1}", obj.StandardId, obj.StandardName));
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Enter standard ID to delete");
                        sobj.StandardId = Convert.ToInt32(Console.ReadLine());
                        b.removeStandard(sobj);
                        Console.WriteLine("Standard removed \n\r Existing Standards:");
                        d = b.getAllStandards();
                        foreach (Standard obj in d)
                        Console.WriteLine(string.Format("{0} - {1}", obj.StandardId, obj.StandardName));
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Enter standard ID  to search");
                        sobj.StandardId = Convert.ToInt32(Console.ReadLine());
                        Standard display = b.GetStandardByID(sobj.StandardId);
                        Console.WriteLine(display.StandardId + "  " + display.StandardName);
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Enter standard ID to display all students related to that stanadard");
                        sobj.StandardId = Convert.ToInt32(Console.ReadLine());
                        Standard s = b.GetStandardByIDWithStudents(sobj.StandardId);
                        if (s == null)
                        {
                            Console.WriteLine("Standard not found!");
                            Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                            again = Convert.ToInt32(Console.ReadLine());
                            break;
                            //return;
                        }
                        else if (s.Students == null || s.Students.Count == 0)
                        {
                            Console.WriteLine("This Standard has no Students!");
                            // Console.Read();
                            Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                            again = Convert.ToInt32(Console.ReadLine());
                            break;
                            //  return;
                        }
                        Console.WriteLine("\nContaining Students: {0}", s.Students.Count);
                        foreach (Student student in s.Students)
                        Console.WriteLine("- " + student.StudentName);
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("Existing Standards:");
                        d = b.getAllStandards();
                        foreach (Standard obj in d)
                        Console.WriteLine(string.Format("{0} - {1}", obj.StandardId, obj.StandardName));
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                        Console.WriteLine("Enter student Name");
                        stuobj.StudentName = Console.ReadLine();
                        Console.WriteLine("Enter standardID");
                        stuobj.StandardId = Convert.ToInt32(Console.ReadLine());
                        b.addStudent(stuobj);
                        Console.WriteLine("Added students:");
                        studs = b.getAllStudents();
                        foreach (Student obj in studs)
                        Console.WriteLine(string.Format("{0} -{1} - {2}", obj.StudentID, obj.StudentName.ToString(), obj.StandardId));
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("Enter student ID to update");
                        stuobj.StudentID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student name to update");
                        stuobj.StudentName = Console.ReadLine();
                        Console.WriteLine("Enter standard ID to update");
                        stuobj.StandardId = Convert.ToInt32(Console.ReadLine());
                        b.UpdateStudent(stuobj);
                        Console.WriteLine("Existing Students:");
                        studs = b.getAllStudents();
                        foreach (Student obj in studs)
                        Console.WriteLine(string.Format("{0} -{1} - {2}", obj.StudentID, obj.StudentName.ToString(), obj.StandardId));
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 9:
                        Console.WriteLine("Enter student ID to delete");
                        stuobj.StudentID = Convert.ToInt32(Console.ReadLine());
                        b.RemoveStudent(stuobj);
                        Console.WriteLine("Standard removed \n\r Existing Students:");
                        studs = b.getAllStudents();
                        foreach (Student obj in studs)
                        Console.WriteLine(string.Format("{0} -{1} - {2}", obj.StudentID, obj.StudentName.ToString(), obj.StandardId));
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("Enter student ID  to search");
                        stuobj.StudentID = Convert.ToInt32(Console.ReadLine());
                        Student sdisplay = b.GetStudentByID(stuobj.StudentID);
                        Console.WriteLine(sdisplay.StudentID + "  " + sdisplay.StudentName + "  " + sdisplay.StandardId);
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 11:
                        studs = b.getAllStudents();
                        foreach (Student obj in studs)
                        Console.WriteLine(string.Format("{0} -{1} - {2}", obj.StudentID, obj.StudentName.ToString(), obj.StandardId));
                        Console.WriteLine("Do you want to continue: press 1 for yes \n\r press 2 for No");
                        again = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }               
            }
            while (again != 2);
        }
        
    }
}
