using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Lab2
{
    public class DomAnalyse : IAnalyser
    {
        public List<Student> Analyse(Student student)
        {
            List<Student> students = new List<Student>();
            var xmlDoc = new XmlDocument();
            XmlReader reader = XmlReader.Create(@"D:\Development\C#\Lab2\Lab2\Dormitory.xml");
            xmlDoc.Load(reader);
            XmlNode node = xmlDoc.DocumentElement;
            foreach (XmlNode nod in node.ChildNodes)
            {
                #region var
                
                string firstName = "";
                string lastName = "";
                string faculty = "";
                string specialization = "";
                string course = "";
                string room = "";
                string whenCheckedInto = "";

                #endregion

                #region fillAttributes
                
                foreach (XmlAttribute attribute in nod.Attributes)
                {
                    if (attribute.Name.Equals("FirstName") && (attribute.Value.Equals(student.FirstName) ||
                                                               student.FirstName == null))
                        firstName = attribute.Value;
                    if (attribute.Name.Equals("LastName") && (attribute.Value.Equals(student.LastName) ||
                                                              student.LastName == null))
                        lastName = attribute.Value;
                    if (attribute.Name.Equals("Faculty") && (attribute.Value.Equals(student.Faculty) ||
                                                             student.Faculty == null))
                        faculty = attribute.Value;
                    if (attribute.Name.Equals("Specialization") && (attribute.Value.Equals(student.Specialization) ||
                                                                    student.Specialization == null))
                        specialization = attribute.Value;
                    if (attribute.Name.Equals("Course") && (attribute.Value.Equals(student.Course) ||
                                                            student.Course == null))
                        course = attribute.Value;
                    if (attribute.Name.Equals("Room") && (attribute.Value.Equals(student.Room) ||
                                                          student.Room == null))
                        room = attribute.Value;
                    if (attribute.Name.Equals("WhenCheckedInto") && (attribute.Value.Equals(student.WhenCheckedInto) ||
                                                                     student.WhenCheckedInto == null))
                        whenCheckedInto = attribute.Value;
                }

                #endregion

                #region ifEmptyFill

                if (firstName != "" && lastName != "" && faculty != "" && specialization != "" && course != "" &&
                    room != "" && whenCheckedInto != "")
                {
                    Student newStudent = new Student();
                    newStudent.FirstName = firstName;
                    newStudent.LastName = lastName;
                    newStudent.Faculty = faculty;
                    newStudent.Specialization = specialization;
                    newStudent.Course = course;
                    newStudent.Room = room;
                    newStudent.WhenCheckedInto = whenCheckedInto;
                    
                    students.Add(newStudent);
                }

                #endregion
                
            }
            return students;
        }
    }
}