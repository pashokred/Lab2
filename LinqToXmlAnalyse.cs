using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Lab2
{
    public class LinqToXmlAnalyse : IAnalyser
    {
        public List<Student> Analyse(Student student)
        {
            List<Student> students = new List<Student>(); 
            var doc = XDocument.Load(@"D:\Development\C#\Lab2\Lab2\Dormitory.xml");
            var result = (from stud in doc.Descendants("Student")
                    where stud.Attribute("FirstName").Value.Equals(student.FirstName) || student.FirstName.Equals(String.Empty)
                    where stud.Attribute("LastName").Value.Equals(student.LastName) || student.LastName.Equals(String.Empty)
                    where stud.Attribute("Faculty").Value.Equals(student.Faculty) || student.Faculty.Equals(String.Empty)
                    where stud.Attribute("Specialization").Value.Equals(student.Specialization) || student.Specialization.Equals(String.Empty)
                    where stud.Attribute("Course").Value.Equals(student.Course) || student.Course.Equals(String.Empty)
                    where stud.Attribute("Room").Value.Equals(student.Room) || student.Room.Equals(String.Empty)
                    where stud.Attribute("WhenCheckedInto").Value.Equals(student.WhenCheckedInto) || student.WhenCheckedInto.Equals(String.Empty)

                    select new Student
                    {
                        FirstName = (string) stud.Attribute("FirstName"),
                        LastName = (string) stud.Attribute("LastName"),
                        Faculty = (string) stud.Attribute("Faculty"),
                        Specialization = (string) stud.Attribute("Specialization"),
                        Course = (string) stud.Attribute("Course"),
                        Room = (string) stud.Attribute("Room"),
                        WhenCheckedInto = (string) stud.Attribute("WhenCheckedInto")
                    }
                ).ToList();
            
            foreach (var stud in result)
            {
                if (stud.FirstName != "" && stud.LastName != "" && stud.Faculty != "" && stud.Specialization != "" && stud.Course != "" &&
                    stud.Room != "" && stud.WhenCheckedInto != "")
                {
                    students.Add(stud);
                }
            }
            return students;
        }
    }
}