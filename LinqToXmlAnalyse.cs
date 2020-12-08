using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Lab2
{
    public class LinqToXmlAnalyse : IAnalyser
    {
        public List<Student> Analyse(Student student)
        {
            List<Student> students = new List<Student>(){}; 
            var doc = XDocument.Load(@"D:\Development\C#\Lab2\Lab2\Dormitory.xml");
            var result = (from stud in doc.Descendants("Student")
                    where stud.Attribute("FirstName").Value.Equals(student.FirstName) || student.FirstName == null
                    where stud.Attribute("LastName").Value.Equals(student.LastName) || student.LastName == null
                    where stud.Attribute("Faculty").Value.Equals(student.Faculty) || student.Faculty == null
                    where stud.Attribute("Specialization").Value.Equals(student.Specialization) || student.Specialization == null
                    where stud.Attribute("Course").Value.Equals(student.Course) || student.Course == null
                    where stud.Attribute("Room").Value.Equals(student.Room) || student.Room == null
                    where stud.Attribute("WhenCheckedInto").Value.Equals(student.WhenCheckedInto) || student.WhenCheckedInto == null

                    select new
                    {
                        firstName = (string) stud.Attribute("FirstName"),
                        lastName = (string) stud.Attribute("LastName"),
                        faculty = (string) stud.Attribute("Faculty"),
                        specialization = (string) stud.Attribute("Specialization"),
                        course = (string) stud.Attribute("Course"),
                        room = (string) stud.Attribute("Room"),
                        whenCheckedInto = (string) stud.Attribute("WhenCheckedInto")
                    }
                ).ToList();
            foreach (var stud in result)
            {
                if (stud.firstName != "" && stud.lastName != "" && stud.faculty != "" && stud.specialization != "" && stud.course != "" &&
                    stud.room != "" && stud.whenCheckedInto != "")
                {
                    Student newStudent = new Student();
                    newStudent.FirstName = stud.firstName;
                    newStudent.LastName = stud.lastName;
                    newStudent.Faculty = stud.faculty;
                    newStudent.Specialization = stud.specialization;
                    newStudent.Course = stud.course;
                    newStudent.Room = stud.room;
                    newStudent.WhenCheckedInto = stud.whenCheckedInto;
                    
                    students.Add(newStudent);
                }
            }
            return students;
        }
    }
}