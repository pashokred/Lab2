using System;
using System.Collections.Generic;
using System.Xml;

namespace Lab2
{
    public class DomAnalyse : IAnalyser
    {
        private Student FillAttributes(XmlNode nod, Student student)
        {
            Student temp = new Student();

            // Check all attributes of student, if there are suitable - change suitable attr
            foreach (XmlAttribute attribute in nod.Attributes)
            {
                if (attribute.Name.Equals("FirstName") && (attribute.Value.Equals(student.FirstName) ||
                                                           student.FirstName.Equals(String.Empty)))
                    temp.FirstName = attribute.Value;
                if (attribute.Name.Equals("LastName") && (attribute.Value.Equals(student.LastName) ||
                                                          student.LastName.Equals(String.Empty)))
                    temp.LastName = attribute.Value;
                if (attribute.Name.Equals("Faculty") && (attribute.Value.Equals(student.Faculty) ||
                                                         student.Faculty.Equals(String.Empty)))
                    temp.Faculty = attribute.Value;
                if (attribute.Name.Equals("Specialization") && (attribute.Value.Equals(student.Specialization) ||
                                                                student.Specialization.Equals(String.Empty)))
                    temp.Specialization= attribute.Value;
                if (attribute.Name.Equals("Course") && (attribute.Value.Equals(student.Course) ||
                                                        student.Course.Equals(String.Empty)))
                    temp.Course = attribute.Value;
                if (attribute.Name.Equals("Room") && (attribute.Value.Equals(student.Room) ||
                                                      student.Room.Equals(String.Empty)))
                    temp.Room = attribute.Value;
                if (attribute.Name.Equals("WhenCheckedInto") && (attribute.Value.Equals(student.WhenCheckedInto) ||
                                                                 student.WhenCheckedInto.Equals(String.Empty)))
                    temp.WhenCheckedInto = attribute.Value;
            }

            return temp;
        }
        
        public List<Student> Analyse(Student student)
        {
            List<Student> students = new List<Student>();
            var xmlDoc = new XmlDocument();
            XmlReader reader = XmlReader.Create(@"D:\Development\C#\Lab2\Lab2\Dormitory.xml");
            
            // Load XML File
            xmlDoc.Load(reader);
            XmlNode node = xmlDoc.DocumentElement;
            
            // Iterate through students
            foreach (XmlNode nod in node.ChildNodes)
            {
                // Fill students attributes
                var temp = FillAttributes(nod, student);
                
                // Add to list if suitable
                if (temp.FirstName != "" && temp.LastName != "" && temp.Faculty != "" && temp.Specialization != "" && temp.Course != "" &&
                    temp.Room != "" && temp.WhenCheckedInto != "")
                {
                    students.Add(temp);
                }
            }
            return students;
        }
    }
}