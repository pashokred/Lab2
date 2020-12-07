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
        public void Analyse(string tag, Dormitory dorm)
        {
            GetElementsByTagName(tag, dorm);
        }
        
        private static void RecurseNodes(XmlNode node)
        {
            var sb = new StringBuilder();
            //починаємо рекурсивний перегляд з рівня 0
            RecurseNodes(node, 0, sb);
            //друкуємо сформований рядок
            Form1.StrBuilder = sb;
        }
        
        private static void RecurseNodes(XmlNode node, int level, StringBuilder sb)
        {
            sb.AppendFormat("{0,-2} Type:{1,-9} Name:{2,-13} Attr:",
                level, node.NodeType, node.Name);
            foreach (XmlAttribute attr in node.Attributes)
            {
                if(attr.Name == "FirstName" && attr.Value == Dorm.FirstName)
                    
                sb.AppendFormat("{0}={1} ", attr.Name, attr.Value);
            }
            sb.AppendLine();
            foreach (XmlNode n in node.ChildNodes)
            {
                RecurseNodes(n, level + 1, sb);
            }
        }
        
        
        private static string GetFilePath(string fileName)
        {
            string path = Directory.GetCurrentDirectory();
            return Path.Combine(GetFilePath("Dormitory.xml"), fileName);
        }

        private static void GetElementsByTagName(string tag, Dormitory dorm)
        {
            var xmlDoc = new XmlDocument();
            XmlReader reader = XmlReader.Create(@"D:\Development\C#\Lab2\Lab2\Dormitory.xml");
            xmlDoc.Load(reader);
            /*DirectoryInfo currentDirectoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            xmlDoc.Load(GetFilePath(@"D:\Development\C#\Lab2\Lab2\Dormitory.xml"));
            */
            
            
            
            var elmts = xmlDoc.GetElementsByTagName(tag);
            var sb = new StringBuilder();
            foreach (XmlNode node in elmts)
            {
                RecurseNodes(node, 0, sb);
            }
            Form1.StrBuilder = sb;
        }
    }
}