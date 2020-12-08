using System.Collections.Generic;
using System.Text;
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
                        
                        #region var
                        
                        string firstName = "";
                        string lastName = "";
                        string faculty = "";
                        string specialization = "";
                        string course = "";
                        string room = "";
                        string whenCheckedInto = "";

                        #endregion

                        if (xmlReader.Name.Equals("FirstName") && (xmlReader.Value.Equals(student.FirstName) ||
                                                                   student.FirstName == null))
                        {
                            firstName = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals("LastName") && (xmlReader.Value.Equals(student.LastName) ||
                                                                      student.LastName == null))
                            {
                                lastName = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();
                                if (xmlReader.Name.Equals("Faculty") && (xmlReader.Value.Equals(student.Faculty) ||
                                                                         student.Faculty == null))
                                {
                                    
                                    faculty = xmlReader.Value;
                                   xmlReader.MoveToNextAttribute();

                                   if (xmlReader.Name.Equals("Specialization") &&
                                       (xmlReader.Value.Equals(student.Specialization) ||
                                        student.Specialization == null))
                                   {                
                                       specialization = xmlReader.Value;
                                       xmlReader.MoveToNextAttribute();
                                       if (xmlReader.Name.Equals("Course") && (xmlReader.Value.Equals(student.Course) ||
                                                                               student.Course == null))
                                       {
                                           course = xmlReader.Value;
                                           xmlReader.MoveToNextAttribute();
                                           if (xmlReader.Name.Equals("Room") && (xmlReader.Value.Equals(student.Room) ||
                                                                                 student.Room == null))
                                           {
                                               room = xmlReader.Value;
                                               xmlReader.MoveToNextAttribute();

                                               if (xmlReader.Name.Equals("WhenCheckedInto") &&
                                                   (xmlReader.Value.Equals(student.WhenCheckedInto) ||
                                                    student.WhenCheckedInto == null))
                                               {
                                                   whenCheckedInto = xmlReader.Value;
                                                   xmlReader.MoveToNextAttribute();
                                               }
                                           }
                                       }
                                   }
                                }
                            }
                        }
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
                }
            }
            
            
            /*
            var sb = new StringBuilder();
            var xmlReader = new XmlTextReader(@"D:\Development\C#\Lab2\Lab2\");

            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.XmlDeclaration:
                    case XmlNodeType.Element:
                    case XmlNodeType.Comment:
                        sb.AppendFormat("{0}: {1} = {2}", xmlReader.NodeType,
                            xmlReader.Name, xmlReader.Value);
                        sb.AppendLine();
                        break;
                    case XmlNodeType.Text:
                        sb.AppendFormat("- Value: {0}", xmlReader.Value);
                        sb.AppendLine();
                        break;
                }

                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        sb.AppendFormat("- Attribute: {0} = {1}", xmlReader.Name,
                            xmlReader.Value);
                        sb.AppendLine();
                    }
                }
            }
            xmlReader.Close();
            return new List<Student>() { };*/
            return students;
        }
    }
}