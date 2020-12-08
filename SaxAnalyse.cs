using System;
using System.Collections.Generic;
using System.Xml;

namespace Lab2
{
    public class SaxAnalyse : IAnalyser
    {
        public List<Student> Analyse(Student student)
        {
            var xmlReader = new XmlTextReader(@"D:\Development\C#\Lab2\Lab2\Dormitory.xml");

            List<Student> students = new List<Student>();

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        Student temp = new Student();

                        if (xmlReader.Name.Equals("FirstName") && (xmlReader.Value.Equals(student.FirstName) ||
                                                                   student.FirstName.Equals(String.Empty)))
                        {
                            temp.FirstName = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals("LastName") && (xmlReader.Value.Equals(student.LastName) ||
                                                                      student.LastName.Equals(String.Empty)))
                            {
                                temp.LastName = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();
                                if (xmlReader.Name.Equals("Faculty") && (xmlReader.Value.Equals(student.Faculty) ||
                                                                         student.Faculty.Equals(String.Empty)))
                                { 
                                    temp.Faculty = xmlReader.Value; 
                                    xmlReader.MoveToNextAttribute();

                                    if (xmlReader.Name.Equals("Specialization") &&
                                       (xmlReader.Value.Equals(student.Specialization) ||
                                        student.Specialization.Equals(String.Empty)))
                                    {                
                                        temp.Specialization = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();
                                        if (xmlReader.Name.Equals("Course") && (xmlReader.Value.Equals(student.Course) ||
                                                                               student.Course.Equals(String.Empty)))
                                        {
                                            temp.Course = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();
                                            if (xmlReader.Name.Equals("Room") && (xmlReader.Value.Equals(student.Room) ||
                                                                                 student.Room.Equals(String.Empty)))
                                            {
                                                temp.Room = xmlReader.Value;
                                                xmlReader.MoveToNextAttribute();

                                                if (xmlReader.Name.Equals("WhenCheckedInto") &&
                                                   (xmlReader.Value.Equals(student.WhenCheckedInto) ||
                                                    student.WhenCheckedInto.Equals(String.Empty)))
                                                {
                                                    temp.WhenCheckedInto = xmlReader.Value;
                                                    xmlReader.MoveToNextAttribute();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (temp.FirstName != "" && temp.LastName != "" && temp.Faculty != "" && temp.Specialization != "" && temp.Course != "" &&
                            temp.Room != "" && temp.WhenCheckedInto != "")
                        {
                            students.Add(temp);
                        }
                    }
                }
            }
            return students;
        }
    }
}