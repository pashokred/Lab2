using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeRadioButtons();
            InitializeComponent();
            LoadDocument();
        }

        private void InitializeRadioButtons()
        {
            GroupBox groupbox = new GroupBox();
            Controls.Add(groupbox);
            groupbox.Controls.Add(LinqBtn);
            groupbox.Controls.Add(DomBtn);
            groupbox.Controls.Add(SaxBtn);
        }

        private List<ComboBox> _comboBoxes = new List<ComboBox>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FillComboBox(XmlNode node)
        {
            if (!comBoxFn.Items.Contains(node.SelectSingleNode("@FirstName").Value))
                comBoxFn.Items.Add(node.SelectSingleNode("@FirstName").Value);
            if (!comBoxLn.Items.Contains(node.SelectSingleNode("@LastName").Value))
                comBoxLn.Items.Add(node.SelectSingleNode("@LastName").Value);
            if (!comBoxFac.Items.Contains(node.SelectSingleNode("@Faculty").Value))
                comBoxFac.Items.Add(node.SelectSingleNode("@Faculty").Value);
            if (!comBoxSpec.Items.Contains(node.SelectSingleNode("@Specialization").Value))
                comBoxSpec.Items.Add(node.SelectSingleNode("@Specialization").Value);
            if (!comBoxCourse.Items.Contains(node.SelectSingleNode("@Course").Value))
                comBoxCourse.Items.Add(node.SelectSingleNode("@Course").Value);
            if (!comBoxRoom.Items.Contains(node.SelectSingleNode("@Room").Value))
                comBoxRoom.Items.Add(node.SelectSingleNode("@Room").Value);
            if (!comBoxCheckIn.Items.Contains(node.SelectSingleNode("@WhenCheckedInto").Value))
                comBoxCheckIn.Items.Add(node.SelectSingleNode("@WhenCheckedInto").Value);
        }

        private void LoadDocument()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(@"D:\Development\C#\Lab2\Lab2\Dormitory.xml");
            
            
            XmlElement dormitory = xmlDoc.DocumentElement;
            XmlNodeList students = dormitory.SelectNodes("Student");

            for (int i = 0; i < students.Count; ++i)
            {
                XmlNode node = students.Item(i);
                FillComboBox(node);
            }
        }
        private void FillTextBox(List<Student> students)
        {
            foreach (var stud in students)
            {
                TextBox.Text += $"First Name: {stud.FirstName}\n" +
                                $"Last Name: {stud.LastName}\n" +
                                $"Faculty: {stud.Faculty}\n" +
                                $"Specialization: {stud.Specialization}\n" +
                                $"Course: {stud.Course}\n" +
                                $"Room: {stud.Room}\n" +
                                $"When checked into: {stud.WhenCheckedInto}\n\n\n";
            }
        }
        
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            _comboBoxes = new List<ComboBox>(){comBoxFn, comBoxLn, comBoxFac, comBoxSpec, comBoxCourse, comBoxRoom, comBoxCheckIn};
            var checkBoxes = new List<CheckBox> {FNchB, LNchB, FACchB, SPECchB, CRSchB, RMchB, CHINchB};
            var checkedComboBoxes = new List<ComboBox>();
            var student = new Student();
            PropertyInfo[] propertyInfos = typeof(Student).GetProperties();
            
            for (int i = 0; i < _comboBoxes.Count; ++i)
            {
                if (checkBoxes[i].Checked)
                {
                    checkedComboBoxes.Add(_comboBoxes[i]);
                    propertyInfos[i].SetValue(student, _comboBoxes[i].SelectedItem.ToString());
                }
            }
            IAnalyser analyser = new DomAnalyse();
            
            if (LinqBtn.Checked)
            {
                analyser = new LinqToXmlAnalyse();
            }
            else if (DomBtn.Checked)
            {
                analyser = new DomAnalyse();
            }
            else if (SaxBtn.Checked)
            {
                analyser = new SaxAnalyse();
            }

            List<Student> students = analyser.Analyse(student);
            FillTextBox(students);
            CreateXmlFromChosen(students);
        }

        private void CreateXmlFromChosen(List<Student> students)
        {
            var xmlDoc = new XmlDocument();
            XmlElement el = xmlDoc.CreateElement("Dormitory");
            xmlDoc.AppendChild(el);
            foreach (var student in students)
            {
                XmlElement childElement = xmlDoc.CreateElement("Student");
                PropertyInfo[] propertyInfos = typeof(Student).GetProperties();
                
                for (int i = 0; i < propertyInfos.Length; ++i)
                {
                    XmlAttribute attribute = xmlDoc.CreateAttribute(propertyInfos[i].Name);
                    attribute.Value = propertyInfos[i].GetValue(student).ToString();
                    childElement.Attributes.Append(attribute);
                }
                el.AppendChild(childElement);
            }
            xmlDoc.Save(@"D:\Development\C#\Lab2\Lab2\SortedDorm.xml");
        }
        
        private void toHtml_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
            string path = @"D:\Development\C#\Lab2\Lab2\";
            xslCompiledTransform.Load(path + "LilBoy.xslt");
            string xmlPath = path + "SortedDorm.xml";
            string htmlPath = path + "Dormitory.html";
            xslCompiledTransform.Transform(xmlPath, htmlPath);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }
    }
}